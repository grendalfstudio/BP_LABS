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
        struct Item
        {
            private string type;
            private int place;
            private float weight;
            private int id;

            public Item(string type, int place, float weight, int id)
            {
                this.type = type;
                this.place = place;
                this.weight = weight;
                this.id = id;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        static int size = 0;
        string type;
        int place;
        float weight;
        int id;
        int index = 0;

        private void BtnSetSize_Click(object sender, EventArgs e)
        {
            try
            {
                size = int.Parse(textSize.Text);
            } catch (Exception)
            {
                textSize.Text = "Incorrect input";
            }
        }
        Item[] items = new Item[size];

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
                items[index] = new Item(type, place, weight, id);
            } catch (IndexOutOfRangeException)
            {
                label1.Text = "IndexOutOfRangeException";
            }
            index++;
            label1.Text = "Added";

        }       
    }
}
