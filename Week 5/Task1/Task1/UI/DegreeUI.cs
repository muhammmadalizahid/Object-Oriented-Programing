using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;


namespace Task1.UI
{
    internal class DegreeUI
    {
        public static string degreeName;
        public static Degree TakeDegreeInfo()
        {
            Console.Write("Enter Degree name: ");
            string name = Console.ReadLine();
            degreeName = name;
            Console.Write("Enter Degree duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter seats for degree: ");
            int seats = int.Parse(Console.ReadLine());
            Degree d = new Degree(name, duration, seats);
            Console.Write("Enter how many subjects do you want to enter: ");
            int count = int.Parse(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                Subject sub= AddSubject();
                d.AddSubjectD(sub);
            }
            DegreeDL.AddDegree(d);
            return d;
        }
        public static Subject AddSubject()
        {
            Console.Write("Enter Subject Code: ");
            string name = Console.ReadLine();
            Console.Write("Enter no of credit hours: ");
            int creditHours= int.Parse(Console.ReadLine());
            Console.Write("Enter Subject type: ");
            string type= Console.ReadLine();
            Console.Write("Enter Subject fee: ");
            float fee= float.Parse(Console.ReadLine());
            return new Subject(name, creditHours, type, fee);
        }
        public static void DegreeStudents(string degreeName)
        {
            List<Student> studentList = StudentDL.getStudentList();
            bool found = false;
            Console.WriteLine($"Students admitted to {degreeName}:");

            foreach (var student in studentList)
            {
                if (student.registeredDegree == degreeName)
                {
                    Console.WriteLine($"{student.name},  Age: {student.age}, FSC Marks: {student.fscMarks}, ECAT Marks: {student.ecatMarks}");
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("No students admitted to this degree.");
            }
        }


    }
}
