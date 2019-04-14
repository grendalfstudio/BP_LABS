using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_LAB_10
{
    public partial class FormMain : Form
    {
        public Firm NewFirm { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }
        private void MenuStripItemCreate_Click(object sender, EventArgs e)
        {
            if(NewFirm == null)
            {
                FormAddFirm formNewFirm = new FormAddFirm();
                formNewFirm.ShowDialog();
                NewFirm = formNewFirm.NewFirm;
                if (NewFirm != null)
                {
                    ActiveForm.Text = NewFirm.Name;
                }
            }
            else
            {
                MessageBox.Show("The firm is already created!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void MenuStripItemWrite_Click(object sender, EventArgs e)
        {
            if (NewFirm != null)
            {
                groupBoxAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Create firm first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MenuStripItemCheck_Click(object sender, EventArgs e)
        {
            if (NewFirm != null)
            {
                groupBoxCheck.Enabled = true;
            }
            else
            {
                MessageBox.Show("Create firm first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MenuStripItemExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxAddName.Text;
            string surname = textBoxAddSurname.Text;
            string date = dateTimePicker.Text;
            string phone = maskedTextBoxTelephone.Text;
            if(name == "" || surname == "" || date == "")
            {
                MessageBox.Show("You must fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee employee = new Employee(name, surname, phone, date, NewFirm);
            NewFirm.Employees.Add(employee);
            MessageBox.Show("Added!", "Employee recruitment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxAddName.Text = "";
            textBoxAddSurname.Text = "";
            dateTimePicker.Text = "";
            maskedTextBoxTelephone.Text = "";
            groupBoxAdd.Enabled = false;
        }
        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            string name = textBoxCheckName.Text;
            string surname = textBoxCheckSurname.Text;
            if (name == "" || surname == "")
            {
                MessageBox.Show("You must fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee employee = new Employee(name, surname, NewFirm);
            string message = employee ? "Yes, he/she works here" : "No, he/she doesn't work here";
            MessageBox.Show(message, "Checking employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxCheckName.Text = "";
            textBoxCheckSurname.Text = "";
            groupBoxCheck.Enabled = false;
        }
    }
    public class Firm
    {
        public string Name { get; }
        public List<Employee> Employees { get; }
        public Firm(string name)
        {
            Name = name;
            Employees = new List<Employee>(100);
        }
    }
    public class Employee
    {
        public static bool operator true(Employee employee)
        {
            return employee.Firm.Employees.Exists(x => (x.Name == employee.Name) && (x.Surname == employee.Surname));
        }
        public static bool operator false(Employee employee)
        {
            return employee.Firm.Employees.Exists(x => (x.Name == employee.Name) && (x.Surname == employee.Surname));
        }
        public string Name { get; }
        public string Surname { get; }
        public string Date { get; }
        public string Phone { get; }
        public Firm Firm { get; }
        public Employee(string name, string surname, string date, string phone, Firm firm)
        {
            Name = name;
            Surname = surname;
            Date = date;
            Phone = phone;
            Firm = Firm;
        }
        public Employee(string name, string surname, Firm firm)
        {
            Name = name;
            Surname = surname;
            Date = null;
            Phone = null;
            Firm = firm;
        }
    }
}
