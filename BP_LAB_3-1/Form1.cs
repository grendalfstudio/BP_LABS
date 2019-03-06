using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_LAB_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Item
        {
            public string type;
            public int place;
            public float weight;
            public int id;

            public Item(string type, int place, float weight, int id)
            {
                this.type = type;
                this.place = place;
                this.weight = weight;
                this.id = id;
            }
        }

        static int capacity = 0; // Capacity of database
        string type;
        int place;
        float weight;
        int id;
        int size = 0; // Current size of database
        Item[] items; // Massive of Items

        private void BtnSetSize_Click(object sender, EventArgs e)
        {
            try
            {
                capacity = int.Parse(textBoxCapacity.Text);
                items = new Item[capacity];

                textBoxCapacity.Enabled = false;
                btnSetSize.Enabled = false;
                btnAdd.Enabled = true;
                textBoxType.Enabled = true;
                textBoxPlace.Enabled = true;
                textBoxWeight.Enabled = true;
                textBoxID.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                type = textBoxType.Text;
                place = int.Parse(textBoxPlace.Text);
                weight = float.Parse(textBoxWeight.Text);
                id = int.Parse(textBoxID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Item item = new Item(type, place, weight, id);
                items[size] = item;
                size++;

                MessageBox.Show("Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("IndexOutOfRangeException", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception)
            {
                MessageBox.Show("IndexOutOfRangeException", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }               

        }
         private void BtnShow_Click(object sender, EventArgs e)
        {
            int showIndex = Convert.ToInt16(numericIndex.Value);
            try
            {
                textBoxTypeShow.Text = items[showIndex].type;
                textBoxPlaceView.Text = Convert.ToString(items[showIndex].place);
                textBoxWeightView.Text = Convert.ToString(items[showIndex].weight);
                textBoxIDView.Text = Convert.ToString(items[showIndex].id);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong\n i.e. IndexOutOfRangeException",
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxType_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void numericIndex_ValueChanged(object sender, EventArgs e)
        {
            label12.Text = "";
        }

        private void textPlace_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void textWeight_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
