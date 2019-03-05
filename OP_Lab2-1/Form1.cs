using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random random = new Random();
        short sizeOneD = 0;
        short sizeTwoD = 0;

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            try
            {
                sizeOneD = short.Parse(textSize.Text);               

                short[] oneDArray = new short[sizeOneD];               

                for (short i = 0; i < sizeOneD; i++)
                {
                    oneDArray[i] = Convert.ToInt16(random.Next(-100, 101));
                }

                dataGridOneDArray.RowCount = 1;
                dataGridOneDArray.ColumnCount = sizeOneD;
                
                for (int i = 0; i < sizeOneD; i++)
                {
                    dataGridOneDArray.Rows[0].Cells[i].Value = oneDArray[i];
                }

                short countEven = 0;
                short sumThreeDiv = 0;
                short difference = 0;

                foreach (short value in oneDArray)
                {
                    if (value % 2 == 0)
                    {
                        countEven++;
                    }
                    if (value % 3 == 0)
                    {
                        sumThreeDiv += value;

                    }
                }

                difference = Convert.ToInt16(oneDArray.Max() - oneDArray.Min());

                textEven.Text = Convert.ToString(countEven);
                textThree.Text = Convert.ToString(sumThreeDiv);
                textDiff.Text = Convert.ToString(difference);

                
            }
            catch (FormatException)
            {
                textSize.Text = "Error - incorrect input";
            }



        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            try
            {
                sizeTwoD = short.Parse(textSizeTwoD.Text);

                short[,] twoDArray = new short[sizeTwoD, sizeTwoD];

                for (short i = 0; i < sizeTwoD; i++)
                {
                    for (short j = 0; j < sizeTwoD; j++)
                    {
                        twoDArray[i,j] = Convert.ToInt16(random.Next(-100, 101));
                    }
                }

                dataGridTwoD.RowCount = sizeTwoD;
                dataGridTwoD.ColumnCount = sizeTwoD;

                for (short i = 0; i < sizeTwoD; i++)
                {
                    for (short j = 0; j < sizeTwoD; j++)
                    {
                        dataGridTwoD[j, i].Value = twoDArray[i, j];
                    }
                }

                short sumBefore = 0;
                short sumAfter = 0;
                short[] arrBefore = new short[sizeTwoD];
                short[] arrAfter = new short[sizeTwoD];

                for (short i = 0; i < sizeTwoD; i++)
                {
                    bool flag = false;
                    sumAfter = 0;
                    for (short j = 0; j < sizeTwoD; j++)
                    {
                        if (twoDArray[i,j] < 0)
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            sumAfter += twoDArray[i, j];
                        }                        
                    }
                    Console.WriteLine(sumAfter);

                    sumAfter += Convert.ToInt16(flag ? 0 : 100);

                    arrAfter[i] = sumAfter;

                }

                for (short i = 0; i < sizeTwoD; i++)
                {
                    bool flag = false;
                    sumBefore = 0;
                    for (short j = 0; j < sizeTwoD; j++)
                    {
                        if (twoDArray[i, sizeTwoD - 1 - j] < 0)
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            sumBefore += twoDArray[i, sizeTwoD - 1 - j];
                        }
                    }

                    sumBefore += Convert.ToInt16(flag ? 0 : -1);

                    arrBefore[i] = sumBefore;

                }

                dataGridResultAfter.RowCount = 1;
                dataGridResultBefore.RowCount = 1;
                dataGridResultBefore.ColumnCount = sizeTwoD;
                dataGridResultAfter.ColumnCount = sizeTwoD;

                for (short i = 0; i < sizeTwoD; i++)
                {
                    dataGridResultAfter.Rows[0].Cells[i].Value = arrAfter[i];
                }

                for (short i = 0; i < sizeTwoD; i++)
                {
                    dataGridResultBefore.Rows[0].Cells[i].Value = arrBefore[i];
                }


            }
            catch (FormatException) {
                textSizeTwoD.Text = "Incorrect input";
            }
        }
    }
}