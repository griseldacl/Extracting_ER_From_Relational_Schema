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
    public partial class MVD_Resolution_Form : Form
    {

        public List<string> mvd = new List<string>();
        public List<string> weak;

        public MVD_Resolution_Form(List<string> weakEntities)
        {
            InitializeComponent();
            weak = weakEntities;

            foreach(string tup in weak)
            {
                weakEntitiesListBox.Items.Add(tup);
            }
        }

        private void moveToMVD(object sender, EventArgs e)
        {
            int index = weakEntitiesListBox.SelectedIndex;
            string item = weak.ElementAt(index);

            mvdListBox.Items.Add(item);
            mvd.Add(item);
            weakEntitiesListBox.Items.Remove(weakEntitiesListBox.SelectedItem);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
