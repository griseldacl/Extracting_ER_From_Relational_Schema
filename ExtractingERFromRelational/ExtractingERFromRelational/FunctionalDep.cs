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
    public partial class FunctionalDep : Form
    {
        public List<Relation> _masterList;
        public Dictionary<string, AttributeType> attrDict = new Dictionary<string, AttributeType>();

        public List<string> lhs_of_FD;
        public List<string> rhs_of_FD;

        public List<Tuple<List<string>, List<string>>> functionalDependencies;

        public FunctionalDep(List<Relation> masterList)
        {
            InitializeComponent();
            _masterList = masterList;

            lhs_of_FD = new List<string>();
            functionalDependencies = new List<Tuple<List<string>, List<string>>>();
            rhs_of_FD = new List<string>();

            foreach(Relation rel in _masterList)
            {
                foreach(KeyValuePair<string, AttributeType> kvp in rel.attributeDict)
                {
                    if(attrDict.ContainsKey(kvp.Key) == false)
                    {
                        attrDict.Add(kvp.Key, kvp.Value);
                        listBoxAttr.Items.Add(kvp.Key);
                    }
                }
            }

        }

        private void buttonAddLHS_Click(object sender, EventArgs e)
        {
            if (listBoxAttr.SelectedItem != null)
            {
                string item = listBoxAttr.SelectedItem.ToString();
                listBoxLHS.Items.Add(item);
                lhs_of_FD.Add(item);
            }
        
        }

        private void buttonAddRHS_Click(object sender, EventArgs e)
        {
            if (listBoxAttr.SelectedItem != null)
            {
                string item = listBoxAttr.SelectedItem.ToString();
                listBoxRHS.Items.Add(item);
                rhs_of_FD.Add(item);
            }
        }

        private void buttonAddFD_Click(object sender, EventArgs e)
        {

            string LHSfdToDisplay = string.Empty;
            string RHSfdToDisplay = string.Empty;
            Tuple<List<string>, List<string>> newFD = new Tuple<List<string>, List<string>>(lhs_of_FD, rhs_of_FD);

            LHSfdToDisplay = lhs_of_FD[0];
            for (int i = 1; i < lhs_of_FD.Count; i++)
            {
                LHSfdToDisplay += ", " + lhs_of_FD[i];
            }

            RHSfdToDisplay = rhs_of_FD[0];
            for (int i = 1; i < rhs_of_FD.Count; i++)
            {
                RHSfdToDisplay += ", " + rhs_of_FD[i];
            }

            listBoxFDs.Items.Add(LHSfdToDisplay + "---->" + RHSfdToDisplay);
            functionalDependencies.Add(newFD);


            rhs_of_FD = new List<string>();
            lhs_of_FD = new List<string>();
            listBoxLHS.Items.Clear();
            listBoxRHS.Items.Clear();
            
             
        }
    }
}
