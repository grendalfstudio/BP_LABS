using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_LAB_6
{
    /*Використати структуру з лабораторної роботи №4. 
     * Створити список структур (розмір задається користувачем), 
     * реалізувати його заповнення з форми, реалізувати додавання, 
     * видалення (за значенням та індексом), вставку, 
     * сортування за одним з текстових полів структури за алфавітом, 
     * пошук з форми.*/

    public struct Item
    {
        private string type;
        private string name;
        private int place;
        private float weight;
        private int id;

        public float Weight { get => weight; set => weight = value; }
        public int Id { get => id; set => id = value; }
        public int Place { get => place; set => place = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }

        public Item(string type, string name, int place, float weight, int id)
        {
            this.type = type;
            this.name = name;
            this.place = place;
            this.weight = weight;
            this.id = id;
        }
    }

    public class TypeComparer : IComparer<Item>
    {
        

        public int Compare(Item x, Item y)
        {
            if (x.Equals(null))
            {
                if (y.Equals(null))
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y.Equals(null))
                    // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    int retval = x.Type.Length.CompareTo(y.Type.Length);

                    if (retval != 0)
                    {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                        return retval;
                    }
                    else
                    {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                        return x.Type.CompareTo(y.Type);
                    }
                }
            }
        }
    }

    public class NameComparer : IComparer<Item>
    {
        

        public int Compare(Item x, Item y)
        {
            if (x.Equals(null))
            {
                if (y.Equals(null))
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y.Equals(null))
                    // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    int retval = x.Name.Length.CompareTo(y.Name.Length);

                    if (retval != 0)
                    {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                        return retval;
                    }
                    else
                    {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                        return x.Name.CompareTo(y.Name);
                    }
                }
            }
        }
    }

    public partial class Form1 : Form
    {
        List<Item> items;
        List<int> ids;
        int size;
        string type;
        string name;
        int place;
        float weight;
        int id;
        int index;
        int indexR;
        int idR;
        string sortChoice;

        public Form1() => InitializeComponent();

        private void btnSetSize_Click(object sender, EventArgs e)
        {
            try
            {
                size = Convert.ToInt32(textSize.Text);
                items = new List<Item>(size);
                ids = new List<int>(size);

                MessageBox.Show("List with capacity "+ size + " created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                type = textType.Text;
                name = textName.Text;
                place = Convert.ToInt32(textPlace.Text);
                weight = (float)Convert.ToDouble(textWeight.Text);
                id = Convert.ToInt32(textId.Text);
                if (items.Count() < size){    
                    Item item = new Item(type, name, place, weight, id);
                    items.Add(item);
                }
                else
                {
                    throw new Exception("List is already full");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                type = textType.Text;
                name = textName.Text;
                place = Convert.ToInt32(textPlace.Text);
                weight = (float)Convert.ToDouble(textWeight.Text);
                id = Convert.ToInt32(textId.Text);
                index = Convert.ToInt32(textIndex.Text);

                if (items.Count() < size){    
                    Item item = new Item(type, name, place, weight, id);
                    items.Insert(index, item);
                }
                else
                {
                    throw new Exception("List is already full");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                indexR = Convert.ToInt32(textIndexR.Text);
                items.RemoveAt(indexR);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRemoveById_Click(object sender, EventArgs e)
        {
            try
            {
                idR = Convert.ToInt32(textIdR.Text);
                Item item = items.Find(x => x.Id == idR);
                if (!item.Equals(null))
                {
                    items.Remove(item);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                sortChoice = boxSortChoice.Text;
                if (sortChoice.Equals("Type"))
                {
                    TypeComparer typeComparer = new TypeComparer();
                    items.Sort(typeComparer);
                }
                else
                {
                    NameComparer nameComparer = new NameComparer();
                    items.Sort(nameComparer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
