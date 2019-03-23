using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_LAB_5
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void btnCalc_Click(object sender, EventArgs e) 
        {
            try
            {
                string input = richTextInput.Text;
                int N = Convert.ToInt32(textN.Text);

                string[] strArray = input.Split(' ');
                if (N > strArray.Length)
                {
                   throw new ArgumentException("N is greater than count of numbers"); 
                }
                else
                {
                    int length = strArray[N - 1].Count();
                    string output = "";
                    foreach (string str in strArray)
                    {
                        if (str.Count() == length)
                        {
                            output += str + " ";
                        }
                    }

                    richTextOutput.Text = output;
                }
            }
            catch (System.Exception ex)
            {
                textN.Text = "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextInput.Text = "";
            richTextOutput.Text = "";
            textN.Text = "";
        }
    }
}
