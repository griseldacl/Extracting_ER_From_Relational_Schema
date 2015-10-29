using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAddition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1;
            int value2;
            bool success = int.TryParse(textBox1.Text, out value1);
            if (success)
            {
                bool success2 = int.TryParse(textBox2.Text, out value2);
                if (success2)
                {
                    int value3 = value1 + value2;
                    textBox3.Text = value3.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Value for 2nd number");
                }

            }
            else
            {
                MessageBox.Show("Invalid Value for 1st number");
            }

        }
    }
}
