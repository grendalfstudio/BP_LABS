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
                uint N = Convert.ToUInt32(textN.Text);

                string[] strArray = input.Split(' ');
                if (N > strArray.Length)
                {
                   throw new ArgumentException("N is greater than count of numbers"); 
                }
                else
                {
                    int length = strArray[N - 1].Length;
                    string output = "";
                    foreach (string str in strArray)
                    {
                        if (str.Length == length)
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

        private void btnCalcSec_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strArraySec = richTextInputSec.Text.Split(' ');
                uint length = Convert.ToUInt32(textLength.Text);

                short count = 0;
                foreach (string str in strArraySec)
                {
                    if (str.Length == length)
                        count++;
                }

                textCount.Text = Convert.ToString(count);
                
            }
            catch (Exception ex)
            {
                textLength.Text = "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearSec_Click(object sender, EventArgs e)
        {
            richTextInputSec.Text = "";
            textLength.Text = "";
            textCount.Text = "";
        }
    }
}
