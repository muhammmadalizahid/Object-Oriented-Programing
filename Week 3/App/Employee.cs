using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Employee
    {
        public Employee(string name, string cnic, string role, string salary)
        {
            Name = name;
            Cnic = cnic;
            Role = role;
            Salary = salary;
        }
        public string Name { get; set; }
        public string Cnic { get; set; }
        public string Role { get; set; }
        public string Salary { get; set; }
        public void EmployeeDetails()
        {
            Console.Write("Enter the name of the Employee: ");
            Name = Console.ReadLine();
            Console.Write("Enter CNIC of the Employee: ");
            Cnic =Console.ReadLine();
            Console.Write("Enter Role of the Employee: ");
            Role = Console.ReadLine();
            Console.Write("Enter Salary of the Employee: ");
            Salary = Console.ReadLine();
        }
        public void DisplayEmployee()
        {
            Console.WriteLine($"Name: {Name}, CNIC: {Cnic}, Role: {Role}, Salary: {Salary}");
        }
    }
}
