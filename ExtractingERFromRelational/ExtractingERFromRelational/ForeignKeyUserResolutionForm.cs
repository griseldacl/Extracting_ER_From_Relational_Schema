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
        public List<Tuple<string, string>> foreignKeyRel;

        public ForeignKeyUserResolutionForm(List<Tuple<string, string>> foreignKeyRelations)
        {
            InitializeComponent();

            foreignKeyRel = foreignKeyRelations;
            foreach(Tuple<string, string> value in foreignKeyRel)
            {

                string output = value.Item1 + ", " + value.Item2;
                foreignKeyRelationListBox.Items.Add(output);
            }
        }

        private void RemoveMapping_Click(object sender, EventArgs e)
        {
            int index = foreignKeyRelationListBox.SelectedIndex;

            foreignKeyRel.RemoveAt(index);

            foreignKeyRelationListBox.Items.Remove(foreignKeyRelationListBox.SelectedItem);

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
