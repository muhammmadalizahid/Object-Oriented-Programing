using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1.UI
{
    internal class StudentUI
    {
        public static Student TakeStudentInfo()
        {
            Console.Write("Enter Student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSC Marks: ");
            int fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Student ECAT Marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());
            Console.Write("Following are the available degree programs: ");
            List<Degree> degreeList = DegreeDL.GetDegreeList();
            foreach (Degree d in degreeList)
            {
                Console.WriteLine(d.name);
            }
            List<string> preference= new List<string>();
            Console.Write("Enter number of preferences you want to enter: ");
            int number= int.Parse(Console.ReadLine());
            for(int i=0; i<number; i++)
            {
                Console.Write("Enter Preference: ");
                string pref= Console.ReadLine();
                if(degreeList.Any(degree=>degree.name==pref))
                {
                    preference.Add(pref);
                }
                else
                {
                    Console.WriteLine("Invalid Degree...");
                }
            }
            float merit = Student.calculateMerit(ecatMarks, fscMarks);
            return new Student(name, age, fscMarks, ecatMarks, merit);
        }
        public static void DisplayStudents()
        {
            List<Student> studentList = StudentDL.getStudentList();

            if (studentList.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("Registered Students:");
            foreach (var student in studentList)
            {
                Console.WriteLine("Name: " + student.name);
                Console.WriteLine("ECAT Marks: " + student.ecatMarks);
                Console.WriteLine("FSC Marks: " + student.fscMarks);
                Console.WriteLine("Age: " + student.age);
                Console.WriteLine();
            }
        }

    }
}
