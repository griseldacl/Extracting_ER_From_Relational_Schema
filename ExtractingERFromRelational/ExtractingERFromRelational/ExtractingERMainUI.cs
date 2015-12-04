using ExtractingERBusinessLogic;
using ExtractingERBusinessLogic.Algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Msagl;


namespace ExtractingERFromRelational
{
    public partial class ExtractingERMainUI : Form
    {
        #region Variables

        /// <summary>
        /// Contains the list of Relations in added by the user.
        /// </summary>
        public static List<Relation> _masterListRelations;

        public const string relNameColumnString = "RelationName";
        public const string primaryKeyColumnString = "PrimaryKey";
        public const string attributesColumnString = "Attributes";

        List<Tuple<string, string, string, string>> foreignKeyRelations = null;
        List<Tuple<string, string>> weakEntities = null;
        List<Tuple<string, List<string>>> relations = null;
        
        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ExtractingERMainUI()
        {
            InitializeComponent();
            _masterListRelations = new List<Relation>();

            //TEST RELATIONS
            Relation r1 = new Relation();
            r1.relationName = "EMPLOYEE";
            r1.primaryKeys.Add("SSN");
            r1.attributeDict.Add("FNAME", AttributeType.varchar);
            r1.attributeDict.Add("LNAME", AttributeType.varchar);
            r1.attributeDict.Add("SSN", AttributeType.varchar);
            r1.attributeDict.Add("DATE_OF_BIRTH", AttributeType.varchar);
            r1.attributeDict.Add("ADDRESS", AttributeType.varchar);
            r1.attributeDict.Add("DNUMBER", AttributeType.integer);
            r1.attributeDict.Add("SALARY", AttributeType.integer);
            r1.attributeDict.Add("SUPER_SSN", AttributeType.varchar);

            Relation r2 = new Relation();
            r2.relationName = "DEPARTMENT";
            r2.primaryKeys.Add("DNUMBER");
            r2.attributeDict.Add("DNAME", AttributeType.varchar);
            r2.attributeDict.Add("DNUMBER", AttributeType.integer);
            r2.attributeDict.Add("MGR_SSN", AttributeType.varchar);
            r2.attributeDict.Add("MGR_START_DATE", AttributeType.date);

            Relation r3 = new Relation();
            r3.relationName = "DEPT_LOCATIONS";
            r3.primaryKeys.Add("DNUMBER");
            r3.primaryKeys.Add("DLOCATION");
            r3.attributeDict.Add("DNUMBER", AttributeType.integer);
            r3.attributeDict.Add("DLOCATION", AttributeType.integer);

            Relation r4 = new Relation();
            r4.relationName = "PROJECT";
            r4.primaryKeys.Add("PNUMBER");
            r4.attributeDict.Add("PNAME", AttributeType.varchar);
            r4.attributeDict.Add("PNUMBER", AttributeType.integer);
            r4.attributeDict.Add("PLOCATION", AttributeType.varchar);
            r4.attributeDict.Add("DNUMBER", AttributeType.integer);

            Relation r5 = new Relation();
            r5.relationName = "WORKS_ON";
            r5.primaryKeys.Add("SSN");
            r5.primaryKeys.Add("PNUMBER");
            r5.attributeDict.Add("SSN", AttributeType.varchar);
            r5.attributeDict.Add("PNUMBER", AttributeType.integer);
            r5.attributeDict.Add("HOURS", AttributeType.integer);
       
            Relation r6 = new Relation();
            r6.relationName = "DEPENDENT";
            r6.primaryKeys.Add("SSN");
            r6.primaryKeys.Add("DEPENDENT_NAME");
            r6.attributeDict.Add("SSN", AttributeType.varchar);
            r6.attributeDict.Add("DEPENDENT_NAME", AttributeType.varchar);
            r6.attributeDict.Add("SEX", AttributeType.varchar);
            r6.attributeDict.Add("BIRTHDAY", AttributeType.date);
            r6.attributeDict.Add("RELATION", AttributeType.varchar);
            
            _masterListRelations.Add(r1);
            _masterListRelations.Add(r2);
            _masterListRelations.Add(r3);
            _masterListRelations.Add(r4);
            _masterListRelations.Add(r5);
            _masterListRelations.Add(r6);
            
            
            // Initializes Columns of the DataGridView
            relationsDataGrid.Columns.Add(relNameColumnString, "RELATION NAME");
            relationsDataGrid.Columns.Add(primaryKeyColumnString, "PRIMARY KEY");
            relationsDataGrid.Columns.Add(attributesColumnString, "ATTRIBUTES");

            RefreshRelationsDataGrid();
        }

        #endregion

        #region Private Helper Methods
        

        /// <summary>
        /// Refreshes the data grid of relations with any new 
        /// relations which were added by the user.
        /// </summary>
        private void RefreshRelationsDataGrid()
        {
            relationsDataGrid.Rows.Clear();
            foreach(Relation rel in _masterListRelations)
            {
                string attributeConcat = string.Empty;

                // Concatenate the attribute list to a comma seperated string
                foreach(KeyValuePair<string, AttributeType> kvp in rel.attributeDict)
                {
                    attributeConcat += kvp.Key + ",";

                }

                string primaryKeyConcat = string.Empty;
                foreach (string s in rel.primaryKeys)
                {
                    primaryKeyConcat += s + ", ";
                }

                relationsDataGrid.Rows.Add(rel.relationName, primaryKeyConcat, attributeConcat);
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Event Handler which executes Opening up a 
        /// new relation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRelationButton_Click(object sender, EventArgs e)
        {

           AddRelationForm newRelation = new AddRelationForm();
            newRelation.ShowDialog();

            // Refresh the list of Relations added to the master list
            RefreshRelationsDataGrid();
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            List<Tuple<string, string, string, string>> fkRelations = ForeignKeyMappingAlgo.CalculateForeignKeys(_masterListRelations);

            weakEntities = WeakEntityIdentificationAlgo.CalculateWeakEntities(_masterListRelations);
            relations = RelationIdentificationAlgo.CalculateRelations(weakEntities);

            EditDistanceAlgo.CalculateEditDistance("abc", "bcd");

            ForeignKeyUserResolutionForm newForm = new ForeignKeyUserResolutionForm(fkRelations);
            newForm.ShowDialog();

            foreignKeyRelations = newForm.foreignKeyRel;

        }

        private void startTransformationButton_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 

            List<Tuple<string, string>> edges = new List<Tuple<string, string>>(); 

            foreach(Relation rel in _masterListRelations)
            {
                graph.AddNode(rel.relationName).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
            }

            foreach (Tuple<string, string> weak in weakEntities)
            {
                graph.AddNode(weak.Item1).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Parallelogram;
            }


            foreach (Tuple<string, List<string>> t in relations)
            {

                graph.AddNode(t.Item1).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;

                foreach (string s in t.Item2)
                {
                    Tuple<string, string> ed = edges.Find(obj => ((obj.Item1 == t.Item1 && obj.Item2 == s) ||
                                        (obj.Item2 == t.Item1 && obj.Item1 == s)));
                    if (ed == null)
                    {
                        Tuple<string, string> edge = new Tuple<string, string>(t.Item1, s);
                        edges.Add(edge);
                        graph.AddEdge(t.Item1, s);
                    }
                }



            }



            foreach (Tuple<string, string, string, string> t in foreignKeyRelations)
            {
                bool success = false;
                foreach (Tuple<string, string> ed in edges)
                {
                    if ((ed.Item1 == t.Item1 && ed.Item2 == t.Item2) ||
                        (ed.Item1 == t.Item2 && ed.Item2 == t.Item1))
                    {
                        success = true;
                    }
                }
                if (success == false)
                {
                    Tuple<string, string> edge = new Tuple<string, string>(t.Item1, t.Item2);
                    edges.Add(edge);
                    graph.AddEdge(t.Item1, t.Item2);
                }

            }
            //graph.AddEdge("A", "B");
            //graph.AddEdge("B", "C");
            //graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            //graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            //graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            //Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            //c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            //c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;




            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
        }
    }
}
