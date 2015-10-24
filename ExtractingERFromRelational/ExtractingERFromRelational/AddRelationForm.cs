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
        public Relation newRelation;

        public AddRelationForm()
        {
            InitializeComponent();
            newRelation = new Relation();
        }

        private void addRelationButton_Click(object sender, EventArgs e)
        {
            if (CheckRelationNamePresent())
            {
                newRelation.relationName = relationNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid relation name.", "Validation Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        
        

        }

        #region Private Helper Methods

        private bool CheckRelationNamePresent()
        {
            if (relationNameTextBox.Text == string.Empty)
                return false;
            else
                return true;
        }

        #endregion
    }
}
