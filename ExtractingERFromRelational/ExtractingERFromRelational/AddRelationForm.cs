using ExtractingERBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractingERFromRelational
{
    public partial class AddRelationForm : Form
    {
        #region Variables

        public Relation newRelation;
        public Dictionary<string, AttributeType> attributeDict;
        public string primaryKey;

        #endregion

        #region Constructor

        public AddRelationForm()
        {
            InitializeComponent();

            //NEW ATTRIBUTE TYPE COMBO BOX
            newAttributeTypeComboBox.Items.Add("varchar");
            newAttributeTypeComboBox.Items.Add("integer");
            newAttributeTypeComboBox.Items.Add("date");
            newAttributeTypeComboBox.Items.Add("real");

            newRelation = new Relation();
            attributeDict = new Dictionary<string, AttributeType>();
            primaryKey = string.Empty;
        }

        #endregion

        #region Private Helper Methods

        private bool CheckRelationNamePresent()
        {
            if (relationNameTextBox.Text == string.Empty)
                return false;
            else
                return true;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Event Handler for adding a new attribute to a relation based
        /// on the user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewAttributeButton_Click(object sender, EventArgs e)
        {
            // Get the attributeName from the textbox entered by the User
            // Get the type of attribute the user selected from the drop down box.
            string attributeName = newAttributeNameTextBox.Text;
            AttributeType attributeType = (AttributeType)Enum.Parse(typeof(AttributeType), newAttributeTypeComboBox.SelectedItem.ToString());

            // Add the newly created attribute to our dictionary
            // Also add it to the list box items, for the user viewing.
            attributeDict.Add(attributeName, attributeType);
            attributesListBox.Items.Add(attributeName);

            // If there is no primary key set, then set the
            // newly added attribute as the primary key.
            if (primaryKey == string.Empty)
            {
                primaryKey = attributeName;
                primaryKeyDisplayLabel.Text = primaryKey;
            }

            // Clear the text in the attribute name text box
            // for the user to enter the next attribute.
            newAttributeNameTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Event Handler for changing the primary Key in the 
        /// relation according to the user's selection in the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setAsPrimaryKeyButton_Click(object sender, EventArgs e)
        {
            primaryKey = attributesListBox.SelectedItem.ToString();
            primaryKeyDisplayLabel.Text = primaryKey;
        }

        /// <summary>
        /// Event handler for deleting an attribute selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteAttributeButton_Click(object sender, EventArgs e)
        {
            // Get the selected Item to be deleted as a string
            string selectedAttribute = attributesListBox.SelectedItem.ToString();

            // If the attribute which is selected is the primary key
            // then we need to reset the primaryKeyDisplayLabel as empty
            // and also reset the primaryKey to empty string as we don't
            // have a primary key anymore.
            if (selectedAttribute == primaryKey)
            {
                primaryKeyDisplayLabel.Text = string.Empty;
                primaryKey = string.Empty;
            }
        
            // Remove the selected item from the
            // dictionary and also the list box.
            attributeDict.Remove(selectedAttribute);
            attributesListBox.Items.Remove(selectedAttribute);
        }

        /// <summary>
        /// Event Handler for the OK Button which adds
        /// the entire relation to be added to the master
        /// list of relations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRelationButton_Click(object sender, EventArgs e)
        {
            // Check if valid Relation Name is present
            if (CheckRelationNamePresent())
            {
                // Check if primary key is set.
                if (primaryKey == string.Empty)
                {
                    MessageBox.Show("Please set one attribute as the Primary Key.", "Validation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Set the new Relation Members
                newRelation.relationName = relationNameTextBox.Text;
                newRelation.attributeDict = attributeDict;
                newRelation.primaryKeys.Add(primaryKey);

                // Add it to the master List of Relations.
                ExtractingERMainUI._masterListRelations.Add(newRelation);
                MessageBox.Show(string.Format("{0} has been successfully added.", newRelation.relationName), "Add Relation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid relation name.", "Validation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        #endregion
    }
}
