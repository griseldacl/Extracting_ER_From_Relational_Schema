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
    public partial class ForeignKeyUserResolutionForm : Form
    {
        public List<Tuple<string, string, string, string>> foreignKeyRel;

        public ForeignKeyUserResolutionForm(List<Tuple<string, string, string, string>> foreignKeyRelations)
        {
            InitializeComponent();

            foreignKeyRel = foreignKeyRelations;
            foreach(Tuple<string, string, string, string> value in foreignKeyRel)
            {

                string output = value.Item1 + ", " + value.Item2 + ", Primary Key =  " + value.Item3 + ", Similar Attribute in Relation 2 = " + value.Item4;
                foreignKeyRelationListBox.Items.Add(output);
            }
        }

        private void RemoveMapping_Click(object sender, EventArgs e)
        {
            string selectedMapping = foreignKeyRelationListBox.SelectedItem.ToString();
            List<string> fields = selectedMapping.Split(',').ToList();

            Tuple<string, string, string, string> foundValue = null;

            foreach (Tuple<string, string, string, string> value in foreignKeyRel)
            {
                if(value.Item1 == fields.ElementAt(0) && value.Item2 == fields.ElementAt(1) &&
                    value.Item3 == fields.ElementAt(2) && value.Item4 == fields.ElementAt(3))
                {
                    foundValue = value;
                    break;
                }
            }

            if(foundValue != null)
            {
                foreignKeyRel.Remove(foundValue);
            }

            foreignKeyRelationListBox.Items.Remove(foreignKeyRelationListBox.SelectedItem);

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
