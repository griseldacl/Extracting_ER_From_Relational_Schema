using ExtractingERBusinessLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            r1.relationName = "Employee";
            r1.primaryKey = "SSN";
            r1.attributeDict.Add("FName", AttributeType.varchar);
            r1.attributeDict.Add("LName", AttributeType.varchar);
            r1.attributeDict.Add("SSN", AttributeType.varchar);
            r1.attributeDict.Add("BDate", AttributeType.varchar);
            r1.attributeDict.Add("Address", AttributeType.varchar);
            r1.attributeDict.Add("DNumber", AttributeType.integer);
            r1.attributeDict.Add("Salary", AttributeType.integer);

            Relation r2 = new Relation();
            r2.relationName = "Department";
            r2.primaryKey = "DNumber";
            r2.attributeDict.Add("DName", AttributeType.varchar);
            r2.attributeDict.Add("DNumber", AttributeType.integer);
            r2.attributeDict.Add("SSN", AttributeType.varchar);
            r2.attributeDict.Add("Mgr_start_date", AttributeType.date);

            Relation r3 = new Relation();
            r3.relationName = "Dept_Locations";
            r3.primaryKey = "DNumber,Dlocation";
            r3.attributeDict.Add("DNumber", AttributeType.integer);
            r3.attributeDict.Add("DLocation", AttributeType.integer);

            Relation r4 = new Relation();
            r4.relationName = "Project";
            r4.primaryKey = "Pnumber";
            r4.attributeDict.Add("Pname", AttributeType.varchar);
            r4.attributeDict.Add("Pnumber", AttributeType.integer);
            r4.attributeDict.Add("Plocation", AttributeType.varchar);
            r4.attributeDict.Add("Dnumber", AttributeType.integer);

            Relation r5 = new Relation();
            r5.relationName = "Works_On";
            r5.primaryKey = "SSN, Pnumber";
            r5.attributeDict.Add("SSN", AttributeType.varchar);
            r5.attributeDict.Add("Pnumber", AttributeType.integer);
            r5.attributeDict.Add("Hours", AttributeType.integer);
       
            Relation r6 = new Relation();
            r6.relationName = "Dependent";
            r6.primaryKey = "SSN,Dependent_name";
            r6.attributeDict.Add("SSN", AttributeType.varchar);
            r6.attributeDict.Add("Dependent_name", AttributeType.varchar);
            r6.attributeDict.Add("Sex", AttributeType.varchar);
            r6.attributeDict.Add("Birthday", AttributeType.date);
            r6.attributeDict.Add("Relation", AttributeType.varchar);
            
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
                relationsDataGrid.Rows.Add(rel.relationName, rel.primaryKey, attributeConcat);
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
            ExtractingERBusinessLogic.Algorithms.ForeignKeyMappingAlgo.CalculateForeignKeyRelations(_masterListRelations);
        }
}
}
