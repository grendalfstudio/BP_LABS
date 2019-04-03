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
      

    public partial class Form1 : Form
    {
        List<Item> items;
        List<int> ids;
        IEnumerable<Item> result;
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

        private void BtnSetSize_Click(object sender, EventArgs e)
        {
            try
            {
                size = Convert.ToInt32(textSize.Text);
                items = new List<Item>(size);
                ids = new List<int>(size);
                numericView.Maximum = 0;
                MessageBox.Show($"List with capacity {size} created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnableAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                type = textType.Text;
                name = textName.Text;
                place = Convert.ToInt32(textPlace.Text);
                weight = (float)Convert.ToDouble(textWeight.Text);
                id = Convert.ToInt32(textId.Text);

                if (items.Count() < size && !ids.Contains(id)){    
                    Item item = new Item(type, name, place, weight, id);
                    items.Add(item);
                    ids.Add(id);
                    numericView.Maximum = items.Count()-1;
                    numericView.Value = 0;
                    MessageBox.Show("Succesfully added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("List is already full or item with this ID already in list");
                }
                

                textType.Text = "";
                textName.Text = "";
                textPlace.Text = "";
                textWeight.Text = "";
                textId.Text = "";

                textTypeShow.Text = items.ElementAt(0).Type;
                textNameShow.Text = items.ElementAt(0).Name;
                textPlaceShow.Text = Convert.ToString(items.ElementAt(0).Place);
                textWeightShow.Text = Convert.ToString(items.ElementAt(0).Weight);
                textIdShow.Text = Convert.ToString(items.ElementAt(0).Id); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                type = textType.Text;
                name = textName.Text;
                place = Convert.ToInt32(textPlace.Text);
                weight = (float)Convert.ToDouble(textWeight.Text);
                id = Convert.ToInt32(textId.Text);
                index = Convert.ToInt32(textIndex.Text);

                if (items.Count() < size && !ids.Exists(x => x == id)){    
                    Item item = new Item(type, name, place, weight, id);
                    items.Insert(index, item);
                    numericView.Maximum = items.Count()-1;
                    numericView.Value = 0;
                }
                else
                {
                    throw new Exception("List is already full or item with this ID already in list");
                }

                MessageBox.Show("Succesfully inserted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textType.Text = "";
                textName.Text = "";
                textPlace.Text = "";
                textWeight.Text = "";
                textId.Text = "";
                textIndex.Text = "";

                ClearShow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                indexR = Convert.ToInt32(textIndexR.Text);
                items.RemoveAt(indexR);
                numericView.Maximum = items.Count()-1;
                numericView.Value = 0;

                MessageBox.Show("Succesfully removed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textIndexR.Text = "";

                ClearShow();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnRemoveById_Click(object sender, EventArgs e)
        {
            try
            {
                idR = Convert.ToInt32(textIdR.Text);
                if (ids.Contains(idR))
                {               
                    items.RemoveAt(items.FindIndex(x => x.Id == idR));
                    numericView.Maximum = items.Count()-1;
                    numericView.Value = 0;
                    MessageBox.Show("Succesfully removed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textIdR.Text = "";
                }

                ClearShow();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            try
            {
                sortChoice = boxSortChoice.Text;
                if (sortChoice.Equals("Type"))
                {
                    TypeComparer typeComparer = new TypeComparer();
                    items.Sort(typeComparer);
                    MessageBox.Show("Sorted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearShow();
                }
                else
                {
                    NameComparer nameComparer = new NameComparer();
                    items.Sort(nameComparer);
                    MessageBox.Show("Sorted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearShow();
                }
                MessageBox.Show("Sorted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string nameSearch = textSearch.Text;

                result = from x in items where x.Name.Contains(nameSearch) select x;
                if (result.Count() > 0)
                {
                    numericSearchResult.Maximum = result.Count()-1;

                    ClearShow();

                    textTypeShow.Text = result.ElementAt(0).Type;
                    textNameShow.Text = result.ElementAt(0).Name;
                    textPlaceShow.Text = Convert.ToString(result.ElementAt(0).Place);
                    textWeightShow.Text = Convert.ToString(result.ElementAt(0).Weight);
                    textIdShow.Text = Convert.ToString(result.ElementAt(0).Id);                                  
                }
                else
                {
                    throw new IndexOutOfRangeException("Item not found");
                }
                

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumericSearchResult_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textTypeShow.Text = result.ElementAt((int)numericSearchResult.Value).Type;
                textNameShow.Text = result.ElementAt((int)numericSearchResult.Value).Name;
                textPlaceShow.Text = Convert.ToString(result.ElementAt((int)numericSearchResult.Value).Place);
                textWeightShow.Text = Convert.ToString(result.ElementAt((int)numericSearchResult.Value).Weight);
                textIdShow.Text = Convert.ToString(result.ElementAt((int)numericSearchResult.Value).Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void EnableAll()
        {
            textId.Enabled = true;
            textType.Enabled = true;
            textName.Enabled = true;
            textWeight.Enabled = true;
            textPlace.Enabled = true;
            textIndex.Enabled = true;
            textIndexR.Enabled = true;
            textIdR.Enabled = true;
            textSearch.Enabled = true;
            textTypeShow.Enabled = true;
            textNameShow.Enabled = true;
            textPlaceShow.Enabled = true;
            textWeightShow.Enabled = true;
            textIdShow.Enabled = true;

            numericSearchResult.Enabled = true;
            numericView.Enabled = true;
            boxSortChoice.Enabled = true;

            btnAdd.Enabled = true;
            btnRemoveById.Enabled = true;
            btnRemoveByIndex.Enabled = true;
            btnSearch.Enabled = true;
            btnInsert.Enabled = true;
            btnSort.Enabled = true;
        }

        private void ClearShow()
        {
            textTypeShow.Text = "";
            textNameShow.Text = "";
            textPlaceShow.Text = "";
            textWeightShow.Text = "";
            textIdShow.Text = "";
        }

        private void NumericView_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textTypeShow.Text = items.ElementAt((int)numericView.Value).Type;
                textNameShow.Text = items.ElementAt((int)numericView.Value).Name;
                textPlaceShow.Text = Convert.ToString(items.ElementAt((int)numericView.Value).Place);
                textWeightShow.Text = Convert.ToString(items.ElementAt((int)numericView.Value).Weight);
                textIdShow.Text = Convert.ToString(items.ElementAt((int)numericView.Value).Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

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
}
