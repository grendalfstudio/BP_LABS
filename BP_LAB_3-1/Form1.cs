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
    }
}
