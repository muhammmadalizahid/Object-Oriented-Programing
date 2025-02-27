using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DL;

namespace Task1.BL
{
    internal class Student
    {
        public string name;
        public int age;
        public int fscMarks;
        public int ecatMarks;
        public float merit;
        public string registeredDegree;
        public Student()
        {

        }
        public Student(string name, int age, int fscMarks, int ecatMarks, float merit)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.merit = merit;
            this.registeredDegree = null;
        }
        public static float calculateMerit(int ecatMarks, int fscMarks)
        {
            return((fscMarks * 60) + (ecatMarks * 40)) / 100;
        }
        public static void generateMerit()
        {
            List<Student> studentList = StudentDL.getStudentList();
            List<Degree> degreeList = DegreeDL.GetDegreeList();

            if (studentList.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }
            for (int i = 0; i < studentList.Count - 1; i++)
            {
                int idx = i;
                for (int j = i + 1; j < studentList.Count; j++)
                {
                    if (studentList[j].merit > studentList[idx].merit)
                    {
                        idx = j;
                    }
                }
                Student temp = studentList[i];
                studentList[i] = studentList[idx];
                studentList[idx] = temp;
            }
            Console.WriteLine("Merit List:");
            foreach (var student in studentList)
            {
                foreach (var degree in degreeList)
                {
                    if (degree.seats > 0)
                    {
                        student.registeredDegree = degree.name;
                        degree.seats--;
                        break;
                    }
                }
                Console.WriteLine($"{student.name} - Merit: {student.merit} - Admitted to: {student.registeredDegree}");
            }
        }
    }
}
