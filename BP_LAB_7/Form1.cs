using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_LAB_7
{
    public partial class Form1 : Form
    {
        List<City> cities = new List<City>(100);
        List<Firm> firms = new List<Firm>(100);
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonAddFirm_Click(object sender, EventArgs e)
        {
            if (textBoxFirmName.Text == "")
            {
                MessageBox.Show("The firm name is empty");
                return;
            }

            Firm firm = new Firm(textBoxFirmName.Text);
            // If firm already exists
            if (firms.Exists(x => x.Name == firm.Name) == false)
            {
                firms.Add(firm);
                comboBoxChooseFirmToAdd.DataSource = firms.Select(x => x.Name).ToList();
                textBoxFirmName.Text = "";
            }
            else
            {
                MessageBox.Show("The firm is already exists");
                textBoxFirmName.Text = "";
            }
        }

        private void ButtonAddOffice_Click(object sender, EventArgs e)
        {
            uint number;
            try
            {
                number = uint.Parse(textBoxOfficeNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The office number must be a positive integer");
                textBoxOfficeNumber.Text = "";
                return;
            }

            Office office = new Office(number);
            // If office doesn't exist in list Offices that are rented by firm which is choosed in comboBoxChooseFirmToAdd
            List<Office> offices = firms.Find(x => x.Name == comboBoxChooseFirmToAdd.Text).Offices;
            if (offices.Exists(y => y.Number == office.Number) == false)
            {
                // then it is added to that list of offices
                firms.Find(x => x.Name == comboBoxChooseFirmToAdd.Text).Offices.Add(office);
                comboBoxChooseOfficeToAdd.DataSource = // list of that offices
                    firms.Find(x => x.Name == comboBoxChooseFirmToAdd.Text).Offices.Select(x => x.Number.ToString()).ToList();
                textBoxOfficeNumber.Text = "";
            }
            else
            {
                MessageBox.Show("The office is already exists");
                textBoxOfficeNumber.Text = "";
            }
        }
    }
    /*
     * Variant 1
     */
    public class City
    {
        public string Name { get; }
        public List<Street> Streets { get; }
        public City(string name)
        {
            Name = name;
        }
    }
    public class Street
    {
        public string Name { get; }
        public List<House> Houses { get; }
        public Street(string name)
        {
            Name = name;
        }
    }
    public class House
    {
        public Point Coordinates { get; }
        public Street Street { get; }
        public House(Street street, Point coordinates)
        {
            Street = street;
            Coordinates = coordinates;
        }
    }
    /*
     * Variant 3
     */
    public class Firm
    {
        public string Name { get; }
        public List<Employee> Employees { get; }
        public List<Office> Offices { get; }
        public Firm(string name)
        {
            Name = name;
            Employees = new List<Employee>(100);
            Offices = new List<Office>(100);
        }
    }
    public class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public Firm Firm { get; }
        public List<Office> Offices { get; }
        public Employee(string name, string surname, Firm firm)
        {
            Name = name;
            Surname = surname;
            Firm = firm;
            Offices = new List<Office>(100);
        }
        public bool IsAccessable(Office office)
        {
            return Firm.Offices.Contains(office);
        }
    }
    public class Office
    {
        public uint Number { get; }
        public List<Employee> Employees { get; }
        public Office(uint number)
        {
            Number = number;
            Employees = new List<Employee>(100);
        }
    }
}
