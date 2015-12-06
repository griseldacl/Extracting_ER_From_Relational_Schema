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

        List<Tuple<string, string>> foreignKeyRelations = null;
        List<Tuple<string, string>> weakEntities = null;
        List<Tuple<string, List<string>>> relations = null;
        List<string> multiValuedAttr = null;
        
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
            CreateInputs();
            
            // Initializes Columns of the DataGridView
            relationsDataGrid.Columns.Add(relNameColumnString, "RELATION NAME");
            relationsDataGrid.Columns.Add(primaryKeyColumnString, "PRIMARY KEY");
            relationsDataGrid.Columns.Add(attributesColumnString, "ATTRIBUTES");

            RefreshRelationsDataGrid();
        }

        #endregion

        #region Private Helper Methods


        private void CreateInputs()
        {
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
        }


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
                relationsDataGrid.Columns[1].Width = 150;
                relationsDataGrid.Columns[2].Width = 450;
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

        private void Foreign_Keys_Call()
        {
            List<Tuple<string, string, string, string>> fkRelations = ForeignKeyMappingAlgo.CalculateForeignKeys(_masterListRelations);

            // Remove Duplicates
            List<Tuple<string, string>> foreign_Keys = new List<Tuple<string, string>>();
            foreach(Tuple<string, string, string, string> tup in fkRelations)
            {
                bool found = false;
                foreach(Tuple<string, string> innerTup in foreign_Keys)
                {
                    if((innerTup.Item1 == tup.Item1 && innerTup.Item2 == tup.Item2)||
                            (innerTup.Item2 == tup.Item1 && innerTup.Item1 == tup.Item2))
                    {
                        found = true;
                    }

                }

                if(!found)
                {
                    Tuple<string, string> newTup = new Tuple<string, string>(tup.Item1, tup.Item2);
                    foreign_Keys.Add(newTup);
                }

            }

            ForeignKeyUserResolutionForm newForm = new ForeignKeyUserResolutionForm(foreign_Keys);
            newForm.ShowDialog();

            foreignKeyRelations = newForm.foreignKeyRel;

        }

        private void DrawForeignKeys()
        {
            Form form = new Form();

            form.Text = "Stage-2 Reverse Engineer : Foreign_Keys";
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 


            foreach (Tuple<string,string> tup in foreignKeyRelations)
            {
                Microsoft.Msagl.Drawing.Node newNode = new Microsoft.Msagl.Drawing.Node(tup.Item1);
                newNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;

                graph.AddNode(newNode);

                Microsoft.Msagl.Drawing.Node newNode2 = new Microsoft.Msagl.Drawing.Node(tup.Item2);
                newNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;

                graph.AddNode(newNode2);

                graph.AddEdge(tup.Item1, tup.Item2);
            }

            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.Show();
        }

        private void Weak_Entities_Call()
        {
            weakEntities = WeakEntityIdentificationAlgo.CalculateWeakEntities(_masterListRelations);
        }

        private void DrawWeakEntities()
        {
            Form form = new Form();

            form.Text = "Stage-3 Reverse Engineer : Foreign_Keys";
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 


            // Draw all the entitites
            foreach(Relation rel in _masterListRelations)
            {
                Microsoft.Msagl.Drawing.Node newNode = new Microsoft.Msagl.Drawing.Node(rel.relationName);
                newNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;

                //Add it to the graph
                graph.AddNode(newNode);
            }

            //Draw all the weak Entities
            foreach(Tuple<string, string> weakEnt in weakEntities)
            {
                graph.AddNode(weakEnt.Item1).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;
                graph.AddEdge(weakEnt.Item1, weakEnt.Item2);
            }

            //Draw all the other relations
            foreach(Tuple<string, string> rel in foreignKeyRelations)
            {
                Tuple<string, string> find = weakEntities.Find(obj => (obj.Item1 == rel.Item1 && obj.Item2 == rel.Item2) || (obj.Item2 == rel.Item1 && obj.Item1 == rel.Item2));
                if(find == null)
                {
                    graph.AddEdge(rel.Item1, rel.Item2);
                }

            }

            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.Show();
        }

        private void Relations_Call()
        {
            relations = RelationIdentificationAlgo.CalculateRelations(weakEntities);
        }

        private void DrawRelations()
        {
            Form form = new Form();

            form.Text = "Stage-4 Reverse Engineer : Relations";
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 


            // Draw all the entitites
            foreach (Relation rel in _masterListRelations)
            {
                Microsoft.Msagl.Drawing.Node newNode = new Microsoft.Msagl.Drawing.Node(rel.relationName);
                newNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;

                //Add it to the graph
                graph.AddNode(newNode);
            }

            //Draw all the weak Entities
            foreach (Tuple<string, string> weakEnt in weakEntities)
            {
                graph.AddNode(weakEnt.Item1).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;
                graph.AddEdge(weakEnt.Item1, weakEnt.Item2);
            }

            int relIndex = 1;
            //Draw all the other relations
            foreach (Tuple<string, string> rel in foreignKeyRelations)
            {

                Tuple<string, string> find = weakEntities.Find(obj => (obj.Item1 == rel.Item1 && obj.Item2 == rel.Item2) || (obj.Item2 == rel.Item1 && obj.Item1 == rel.Item2));
                if (find == null)
                {
                    string intermediateRel = "R" + relIndex;
                    graph.AddNode(intermediateRel);
                    graph.AddNode(intermediateRel).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                    graph.AddEdge(rel.Item1, intermediateRel);
                    graph.AddEdge(intermediateRel, rel.Item2);
                    relIndex++;
                }
            }

            //Draw the relations as Diamonds
            foreach(Tuple<string, List<string>> tup in relations)
            {
                graph.AddNode(tup.Item1).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            }

            foreach(string s in multiValuedAttr)
            {
                graph.AddNode(s).Attr.Shape = Microsoft.Msagl.Drawing.Shape.DoubleCircle;
            }

            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.Show();
        }

        private void ResolveWeakEntities_MVD()
        {
            List<string> weak = new List<string>();

            foreach(Tuple<string, string> tup in weakEntities)
            {
                Tuple<string, List<string>> find = relations.Find(obj => obj.Item1 == tup.Item1 || obj.Item1 == tup.Item2);
                if(find == null)
                {
                    string n = tup.Item1;
                    weak.Add(n);
                }
            }

            MVD_Resolution_Form mvd_form = new MVD_Resolution_Form(weak);
            mvd_form.ShowDialog();
            multiValuedAttr = mvd_form.mvd;
        }

        private void stage_1_Entities_Identification_Click(object sender, EventArgs e)
        {
            Form form = new System.Windows.Forms.Form();

            form.Text = "Stage-1 Reverse Engineer : Entities";
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 


            foreach(Relation rel  in _masterListRelations)
            {
                Microsoft.Msagl.Drawing.Node newNode = new Microsoft.Msagl.Drawing.Node(rel.relationName);
                newNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;

                graph.AddNode(newNode);
            }



            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.Size = new Size(500, 500);
            form.ResumeLayout();
            //show the form 
            form.Show();

        }

        private void stage_2_ForeignKey_button_Click(object sender, EventArgs e)
        {
            Foreign_Keys_Call();
            DrawForeignKeys();
        }

        private void stage_3_Weak_Entities_Button_Click(object sender, EventArgs e)
        {
            Weak_Entities_Call();
            DrawWeakEntities();
        }

        private void stage_4_Relations_Button_Click(object sender, EventArgs e)
        {
            Relations_Call();
            ResolveWeakEntities_MVD();
            DrawRelations();
        }

        private void functionalDependencies_Click(object sender, EventArgs e)
        {
            FunctionalDep fd_Form = new FunctionalDep(_masterListRelations);
            fd_Form.ShowDialog();
        }
    }
}
