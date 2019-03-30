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
        public Form1()
        {
            InitializeComponent();
        }
    }

    namespace Variant1
    {
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
    
    namespace Variant3
    {
        public class Firm
        {
            public string Name { get; }
            public List<Employee> Employees { get; }
            public List<Office> Offices { get; }
            public Firm(string name)
            {
                Name = name;
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
            }
            public bool IsAccessable(Office office)
            {
                return Firm.Offices.Contains(office);
            }
        }
        public class Office
        {
            public string Name { get; }
            public List<Employee> Employees { get; }
            public Office(string name)
            {
                Name = name;
            }
        }
    }
}
