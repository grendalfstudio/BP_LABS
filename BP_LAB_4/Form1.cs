using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BP_LAB_4
{
    public partial class FormFileTask : Form
    {
        public FormFileTask() => InitializeComponent();

        //
        // First task
        //

        static string path = "C:\\Users\\MykolaV\\source\\repos\\C#\\BP_LABS\\BP_LAB_4\\f.txt";
        static IEnumerable<double> numbers;


        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                richTextViewFile.Text = File.ReadAllText(path, Encoding.UTF8);
                IEnumerable<string> textEnumerable = File.ReadLines(path);

                numbers = from i in textEnumerable
                          let number = Convert.ToDouble(i)
                          select number;


            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double max = numbers.Max();
                LinkedList<double> evens = new LinkedList<double>();
                for (int i = 0; i < numbers.Count(); i++)
                {
                    if(i%2==0) evens.AddLast(numbers.ElementAt(i));
                }
                double minEven = evens.Min();

                textMax.Text = Convert.ToString(max);
                textMinEven.Text = Convert.ToString(minEven);
            } 
            catch (Exception)
            {
                MessageBox.Show("File not opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            richTextViewFile.Text = "";
            textMax.Text = "";
            textMinEven.Text ="";
        }

        //
        // Second task
        //

        string filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\File.txt";

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxFileContents.Text = File.ReadAllText(filePath, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            richTextBoxFileContents.Text = "";
            textBoxSum.Text = "";
            textBoxProduct.Text = "";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            string[] splitText = richTextBoxFileContents.Text.Split('\n');
            double  sum = 0.0,
                    product = 1.0;
            try
            {
                for (int i = 0; i < splitText.GetLength(0); i++)
                {
                    sum += Convert.ToDouble(splitText[i]);
                    product *= Convert.ToDouble(splitText[i]);
                }
                textBoxSum.Text = sum.ToString("#0.0####");
                textBoxProduct.Text = product.ToString("#0.0####");
            }
            catch (Exception ex)
            {
                MessageBox.Show( (richTextBoxFileContents.Text != "" ? "There is an error in file!" : " The file is empty"),
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
