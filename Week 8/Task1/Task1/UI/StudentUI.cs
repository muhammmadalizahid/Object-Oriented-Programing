using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1.UI
{
    class StudentUI : PersonUI
    {
        public static Student takeStudentInfo()
        {
            Person basePerson = PersonUI.takePersonInfo();
            Console.WriteLine("Enter Program: ");
            string program = Console.ReadLine();
            Console.WriteLine("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());
            Student student = new Student(basePerson.Name, basePerson.Address, program, year, fee);
            Student.addToList(student);
            Console.WriteLine("Student added successfully.");
            return student;
        }
    }
}
