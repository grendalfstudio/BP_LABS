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
        Firm choosedFirmToAdd;  // Firm which is choosed in combo box to add info
        public Form1()
        {
            InitializeComponent();
        }
        // Adding buttons
        private void ButtonAddFirm_Click(object sender, EventArgs e)
        {
            if (textBoxFirmName.Text == "")
            {
                MessageBox.Show("Firm name is empty");
                return;
            }

            Firm firm = new Firm(textBoxFirmName.Text);
            // If firm already exists
            if (firms.Exists(x => x.Name == firm.Name) == false)
            {
                firms.Add(firm);
                comboBoxChooseFirmToAdd.DataSource = firms.Select(x => x.Name).ToList();
                comboBoxChooseFirmToShow.DataSource = firms.Select(x => x.Name).ToList();
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("The firm is already exists");
            }
            textBoxFirmName.Text = "";
        }

        private void ButtonAddOffice_Click(object sender, EventArgs e)
        {
            if (choosedFirmToAdd == null)
            {
                MessageBox.Show("Choose firm first!");
                return;
            }
            uint number;
            try
            {
                number = uint.Parse(textBoxOfficeNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Office number must be a positive integer");
                textBoxOfficeNumber.Text = "";
                return;
            }

            Office office = new Office(number);
            // Get the firm which is choosed in comboBoxChooseFirmToAdd
            if (choosedFirmToAdd.Offices.Exists(y => y.Number == office.Number) == false)
            {
                choosedFirmToAdd.Offices.Add(office);
                comboBoxChooseOfficeToAdd.DataSource = choosedFirmToAdd.Offices.Select(x => x.Number.ToString()).ToList();
                listBoxFirmOffices.DataSource = choosedFirmToShow.Offices.Select(x => x.Number.ToString()).ToList();
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("The office is already exists");
            }
            textBoxOfficeNumber.Text = "";
        }

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (choosedFirmToAdd == null)
            {
                MessageBox.Show("Choose firm first!");
                return;
            }
            if (textBoxEmployeeName.Text == "" || textBoxEmployeeSurname.Text == "")
            {
                MessageBox.Show("Employee's name or surname is empty");
                textBoxEmployeeName.Text = "";
                textBoxEmployeeSurname.Text = "";
                return;
            }
            string  EmployeeName = textBoxEmployeeName.Text,
                    EmployeeSurname = textBoxEmployeeSurname.Text;
            // Get the firm which is choosed in comboBoxChooseFirmToAdd
            if (choosedFirmToAdd.Employees.Exists(y => (y.Name == EmployeeName) && (y.Surname == EmployeeSurname) ) == false)
            {
                Employee employee = new Employee(EmployeeName, EmployeeSurname, choosedFirmToAdd);
                choosedFirmToAdd.Employees.Add(employee);
                comboBoxChooseEmployeeToAdd.DataSource = choosedFirmToAdd.Employees.Select(x => x.Name + " " + x.Surname).ToList();
                listBoxFirmEmployees.DataSource = choosedFirmToShow.Employees.Select(x => x.Name + " " + x.Surname).ToList();
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("The employee is already in this firm");
            }
            textBoxEmployeeName.Text = "";
            textBoxEmployeeSurname.Text = "";
        }

        private void ComboBoxChooseFirmToAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedFirmToAdd = firms.Find(x => x.Name == comboBoxChooseFirmToAdd.Text);
            comboBoxChooseOfficeToAdd.DataSource = choosedFirmToAdd.Offices.Select(x => x.Number.ToString()).ToList();
            comboBoxChooseOfficeToAdd.Refresh();
            comboBoxChooseEmployeeToAdd.DataSource = choosedFirmToAdd.Employees.Select(x => x.Name + " " + x.Surname).ToList();
            comboBoxChooseEmployeeToAdd.Refresh();
        }

        private void ButtonGiveAccessToOffice_Click(object sender, EventArgs e)
        {
            if (choosedFirmToAdd == null)
            {
                MessageBox.Show("Choose firm first!");
                return;
            }
            string  employeeString = comboBoxChooseEmployeeToAdd.Text,
                    officeString = comboBoxChooseOfficeToAdd.Text;
            Employee employee = choosedFirmToAdd.Employees.Find(x => x.Name + " " + x.Surname == employeeString);
            Office office = choosedFirmToAdd.Offices.Find(x => x.Number.ToString() == officeString);
            if (employee.Offices.Exists(x => x.Number == office.Number) == false)
            {
                employee.Offices.Add(office);
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("The employee has an access to this office already");
            }
        }

        // Showing buttons
        private Firm choosedFirmToShow;  // Firm which is choosed in combo box to show info

        private void ComboBoxChooseFirmToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedFirmToShow = firms.Find(x => x.Name == comboBoxChooseFirmToShow.Text);
            listBoxFirmEmployees.DataSource = choosedFirmToShow.Employees.Select(x => x.Name + " " + x.Surname).ToList();
            listBoxFirmOffices.DataSource = choosedFirmToShow.Offices.Select(x => x.Number.ToString()).ToList();
            listBoxAccessableOffices.DataSource = choosedFirmToShow.Offices.Select(x => x.Employees).ToList();
            /*comboBoxChooseOfficeToAdd.DataSource = choosedFirmToAdd.Offices.Select(x => x.Number.ToString()).ToList();
            comboBoxChooseOfficeToAdd.Refresh();
            comboBoxChooseEmployeeToAdd.DataSource = choosedFirmToAdd.Employees.Select(x => x.Name + " " + x.Surname).ToList();
            comboBoxChooseEmployeeToAdd.Refresh();*/
        }

        private void ComboBoxChooseEmployeeToShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxChooseOfficeToShow_SelectedIndexChanged(object sender, EventArgs e)
        {

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
