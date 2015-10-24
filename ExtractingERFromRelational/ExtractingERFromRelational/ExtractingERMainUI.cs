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
    public partial class ExtractingERMainUI : Form
    {

        List<Relation> _masterListRelations;

        public ExtractingERMainUI()
        {
            InitializeComponent();
            _masterListRelations = new List<Relation>();
        }

        private void addRelationButton_Click(object sender, EventArgs e)
        {
            AddRelationForm newRelation = new AddRelationForm();
            newRelation.ShowDialog();
        }
    }
}
