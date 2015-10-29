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

            // Initializes Columns of the DataGridView
            relationsDataGrid.Columns.Add(relNameColumnString, "RELATION NAME");
            relationsDataGrid.Columns.Add(primaryKeyColumnString, "PRIMARY KEY");
            relationsDataGrid.Columns.Add(attributesColumnString, "ATTRIBUTES");
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
    }
}
