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
        List<Firm> firms = new List<Firm>(100);
        Firm choosedFirmToAdd;          // Firm which is choosed in comboBoxFirmToAdd to add info
        public Form1()
        {
            InitializeComponent();
        }
        /// Adding buttons
        private void ButtonAddFirm_Click(object sender, EventArgs e)
        {   /// Exit cases
            if (textBoxFirmName.Text == "")
            {
                MessageBox.Show("Firm name is empty", "Info");
                return;
            }
            Firm firm = new Firm(textBoxFirmName.Text);
            textBoxFirmName.Text = "";
            /// Main work
            if (firms.Exists(x => x.Name == firm.Name) == false)     /// If firm doesn't exist
            {
                firms.Add(firm);
                MessageBox.Show("Added", "Info");
                /// Refreshing the comboBoxes with a new data
                comboBoxChooseFirmToAdd.DataSource = firms.Select(x => x.Name).ToList();
                comboBoxChooseFirmToShow.DataSource = firms.Select(x => x.Name).ToList();
            }
            else
            {
                MessageBox.Show("The firm is already exists", "Info");
            }
        }

        private void ButtonAddOffice_Click(object sender, EventArgs e)
        {   /// Exit cases
            if (choosedFirmToAdd == null)
            {
                MessageBox.Show("Choose firm first!", "Info");
                return;
            }
            uint number;
            try
            {
                number = uint.Parse(textBoxOfficeNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Office number must be only a positive integer", "Info");
                textBoxOfficeNumber.Text = "";
                return;
            }
            Office office = new Office(number);
            textBoxOfficeNumber.Text = "";
            /// Get the firm which is choosed in comboBoxChooseFirmToAdd
            if (choosedFirmToAdd.Offices.Exists(y => y.Number == office.Number) == false)
            {
                choosedFirmToAdd.Offices.Add(office);
                MessageBox.Show("Added", "Info");
                /// Refreshing the comboBoxes with a new data
                comboBoxChooseOfficeToAdd.DataSource = choosedFirmToAdd.Offices.Select(x => x.Number.ToString()).ToList();
                comboBoxChooseOfficeToAdd.Refresh();
                listBoxFirmOffices.DataSource = choosedFirmToShow.Offices.Select(x => x.Number.ToString()).ToList();
                comboBoxChooseOfficeToShow.DataSource = choosedFirmToShow.Offices.Select(x => x.Number.ToString()).ToList();
            }
            else
            {
                MessageBox.Show("The office is already exists", "Info";
            }
        }

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (choosedFirmToAdd == null)
            {
                MessageBox.Show("Choose firm first!", "Info");
                return;
            }
            if (textBoxEmployeeName.Text == "" || textBoxEmployeeSurname.Text == "")
            {
                MessageBox.Show("Employee's name or surname is empty", "Info");
                textBoxEmployeeName.Text = "";
                textBoxEmployeeSurname.Text = "";
                return;
            }

            string EmployeeName = textBoxEmployeeName.Text;
            string EmployeeSurname = textBoxEmployeeSurname.Text;
            textBoxEmployeeName.Text = "";
            textBoxEmployeeSurname.Text = "";
            // Get the firm which is choosed in comboBoxChooseFirmToAdd
            if (choosedFirmToAdd.Employees.Exists(y => (y.Name == EmployeeName) && (y.Surname == EmployeeSurname) ) == false)
            {
                Employee employee = new Employee(EmployeeName, EmployeeSurname, choosedFirmToAdd);
                choosedFirmToAdd.Employees.Add(employee);
                MessageBox.Show("Added", "Info");
                /// Refreshing the comboBoxes with a new data
                comboBoxChooseEmployeeToAdd.DataSource = 
                    choosedFirmToAdd.Employees.Select(x => x.Name + " " + x.Surname).ToList();
                comboBoxChooseEmployeeToAdd.Refresh();
                listBoxFirmEmployees.DataSource = choosedFirmToShow.Employees.Select(x => x.Name + " " + x.Surname).ToList();
                comboBoxChooseEmployeeToShow.DataSource = 
                    choosedFirmToShow.Employees.Select(x => x.Name + " " + x.Surname).ToList();
            }
            else
            {
                MessageBox.Show("The employee is already in this firm", "Info");
            }
        }

        private void ComboBoxChooseFirmToAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedFirmToAdd = firms.Find(x => x.Name == comboBoxChooseFirmToAdd.Text);
            /// Refreshing the comboBoxes with a new data
            comboBoxChooseOfficeToAdd.DataSource = choosedFirmToAdd.Offices.Select(x => x.Number.ToString()).ToList();
            comboBoxChooseEmployeeToAdd.DataSource = 
                choosedFirmToAdd.Employees.Select(x => x.Name + " " + x.Surname).ToList();
            comboBoxChooseOfficeToAdd.Refresh();
            comboBoxChooseEmployeeToAdd.Refresh();
        }

        private void ButtonGiveAccessToOffice_Click(object sender, EventArgs e)
        {
            if (choosedFirmToAdd == null)
            {
                MessageBox.Show("Choose firm first!", "Info");
                return;
            }
            string employeeString = comboBoxChooseEmployeeToAdd.Text;
            string officeString = comboBoxChooseOfficeToAdd.Text;
            Employee employee = choosedFirmToAdd.Employees.Find(x => x.Name + " " + x.Surname == employeeString);
            Office office = choosedFirmToAdd.Offices.Find(x => x.Number.ToString() == officeString);
            if (employee.Offices.Exists(x => x.Number == office.Number) == false)
            {
                employee.Offices.Add(office);
                MessageBox.Show("Added", "Info");
                /// Refreshing the comboBoxes with a new data
                if(choosedEmployeeToShow != null)
                    listBoxAccessableOffices.DataSource = choosedEmployeeToShow.Offices.Select(x => x.Number.ToString()).ToList();
                if (choosedOfficeToShow != null)
                {
                    List<string> employees = new List<string>(100);
                    foreach (Employee employe in choosedFirmToShow.Employees)
                    {
                        if (employe.Offices.Contains(choosedOfficeToShow) == true)
                        {
                            employees.Add(employe.Name + " " + employe.Surname);
                        }
                    }
                    listBoxOfficeStaff.DataSource = employees;
                }
            }
            else
            {
                MessageBox.Show("The employee has an access to this office already", "Info");
            }
        }

        // Showing buttons
        private Firm choosedFirmToShow;         // Firm which is choosed in combo box to show info
        private Employee choosedEmployeeToShow; // Employee which is choosed in combo box to show info
        private Office choosedOfficeToShow;     // Office which is choosed in combo box to show info

        private void ComboBoxChooseFirmToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedFirmToShow = firms.Find(x => x.Name == comboBoxChooseFirmToShow.Text);
            /// Refreshing the comboBoxes and listBoxes with a new data
            listBoxFirmEmployees.DataSource = choosedFirmToShow.Employees.Select(x => x.Name + " " + x.Surname).ToList();
            listBoxFirmOffices.DataSource = choosedFirmToShow.Offices.Select(x => x.Number.ToString()).ToList();
            comboBoxChooseEmployeeToShow.DataSource = choosedFirmToShow.Employees.Select(x => x.Name + " " + x.Surname).ToList();
            comboBoxChooseOfficeToShow.DataSource = choosedFirmToShow.Offices.Select(x => x.Number.ToString()).ToList();
        }

        private void ComboBoxChooseEmployeeToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedEmployeeToShow = 
                choosedFirmToShow.Employees.Find(x => (x.Name + " " + x.Surname) == comboBoxChooseEmployeeToShow.Text);
            /// Refreshing the listBox with a new data
            if(choosedEmployeeToShow != null)
                listBoxAccessableOffices.DataSource = choosedEmployeeToShow.Offices.Select(x => x.Number.ToString()).ToList();
        }

        private void ComboBoxChooseOfficeToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedOfficeToShow = 
                choosedFirmToShow.Offices.Find(x => x.Number.ToString() == comboBoxChooseOfficeToShow.Text);
            /// Refreshing the comboBoxes and listBoxes with a new data
            if(choosedOfficeToShow != null)
            {
                List<string> employees = new List<string>(100);
                foreach (Employee employee in choosedFirmToShow.Employees)
                {
                    if(employee.Offices.Contains(choosedOfficeToShow) == true)
                    {
                        employees.Add(employee.Name + " " + employee.Surname);
                    }
                }
                listBoxOfficeStaff.DataSource = employees;
            }
        }
    }
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
        public Office(uint number)
        {
            Number = number;
        }
    }
}
