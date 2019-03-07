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
        int index = 0; // Current insertion index
        Item[] items; // Massive of Items

        private void BtnSetSize_Click(object sender, EventArgs e)
        {
            try
            {
                capacity = int.Parse(textBoxCapacity.Text);
                if (capacity == 0)
                {

                    MessageBox.Show("Size mustn't be a zero!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCapacity.Text = "";
                    return;
                }
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
                textBoxCapacity.Text = "";
                return;
            }

            numericIndex.Maximum = capacity - 1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                type = textBoxType.Text;
                place = int.Parse(textBoxPlace.Text);
                weight = float.Parse(textBoxWeight.Text);
                id = int.Parse(textBoxID.Text);
                Item item = new Item(type, place, weight, id);
                items[index] = item;
                index++;
            } catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index out of range", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCapacity.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCapacity.Text = "";
                return;
            }

            

            textBoxType.Text = "";
            textBoxPlace.Text = "";
            textBoxWeight.Text = "";
            textBoxID.Text = "";

            MessageBox.Show("Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            short showIndex = Convert.ToInt16(numericIndex.Value);
            try
            {

                textBoxTypeShow.Text = items[showIndex].type;
                textBoxPlaceView.Text = Convert.ToString(items[showIndex].place);
                textBoxWeightView.Text = Convert.ToString(items[showIndex].weight);
                textBoxIDView.Text = Convert.ToString(items[showIndex].id);
            }
            catch (Exception)
            {
                MessageBox.Show("Something goes wrong\n f.e. IndexOutOfRangeException",
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
