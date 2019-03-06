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

        static int size = 0;
        string type;
        int place;
        float weight;
        int id;
        int index = 0;
        Item[] items;

        private void BtnSetSize_Click(object sender, EventArgs e)
        {
            try
            {
                size = int.Parse(textSize.Text);
                items = new Item[size];
                textType.Enabled = true;
                textPlace.Enabled = true;
                textWeight.Enabled = true;
                textID.Enabled = true;
                textSize.Enabled = false;
                btnSetSize.Enabled = false;
                btnAdd.Enabled = true;
            } catch (Exception)
            {
                textSize.Text = "Incorrect input";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                type = textType.Text;
                place = int.Parse(textPlace.Text);
                weight = float.Parse(textWeight.Text);
                id = int.Parse(textID.Text);
            } catch (Exception)
            {
                label1.Text = "Incorrect input";
            }
            try{
                Item item = new Item(type, place, weight, id);
                items[index] = item;
                index++;
                label1.Text = "Added";
            } catch (IndexOutOfRangeException)
            {
                label1.Text = "IndexOutOfRangeException";
            }
            

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int showIndex = Convert.ToInt16(numericIndex.Value);
            try{
                textTypeView.Text = items[showIndex].type;
                textPlaceView.Text = Convert.ToString(items[showIndex].place);
                textWeightView.Text = Convert.ToString(items[showIndex].weight);
                textIDView.Text = Convert.ToString(items[showIndex].id);
            } catch (Exception)
            {
                label12.Text = "Something went wrong\n" +
                                "i.e. IndexOutOfRangeException";
            }
        }

        private void textType_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void numericIndex_ValueChanged(object sender, EventArgs e)
        {
            label12.Text = "";
        }
    }
}
