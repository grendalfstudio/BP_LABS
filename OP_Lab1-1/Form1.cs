using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Lab1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            long m = 0;
            short k = 0;
            double sum = 0;

            //processing FormatException
            try
            {
                m = long.Parse(mText.Text);
                k = short.Parse(kText.Text);

                if (k > 0 && k <= 30)
                {
                    for (short i = 1; i <= k; i++)
                    {
                        sum += Math.Sqrt(m * (1 / i)) * Math.Sin(m * i);
                    }
                    resLabel.Text = Convert.ToString(Math.Round(sum, 3));
                }
                else
                {
                    resLabel.Text = "Error : incorrect k - must be between 0 and 31";
                }
            }
            catch (System.FormatException)
            {
                resLabel.Text = "Incorrect input - must be integer numbers";
            }
            

            
        }
    }
}
