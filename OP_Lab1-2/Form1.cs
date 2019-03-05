using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            long z = 0;
            short k = 0;
            double sum = 0;

            //processing FormatException
            try
            {
                z = long.Parse(zText.Text);
                k = short.Parse(kText.Text);

                if (k > 0 && k < 15)
                {
                    for (short i = 1; i <= k; i++)
                    {
                        {
                            sum += (1 / Math.Sqrt(z * i)) + Math.Tan(k / i);
                        }
                    }
                    resLabel.Text = Convert.ToString(Math.Round(sum, 3));
                }
                else
                {
                    resLabel.Text = "Error : incorrect k - must be between 0 and 15";
                }
            }
            catch (System.FormatException)
            {
                resLabel.Text = "Incorrect input - must be integer numbers";
            }
        }
    }
}
