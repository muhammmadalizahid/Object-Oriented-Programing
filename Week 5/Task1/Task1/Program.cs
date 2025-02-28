using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;
using Task1.UI;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;   
            while (condition)
            {
                Console.Clear();
                string choice = MainMenuUI.Menu();
                switch (choice)
                {
                    case "1":
                        Student s = StudentUI.TakeStudentInfo();
                        StudentDL.AddStudent(s);
                        break;

                    case "2":
                        Degree d = DegreeUI.TakeDegreeInfo();
                        break;

                    case "3":
                        Student.generateMerit();
                        Console.ReadKey();
                        break;

                    case "4":
                        StudentUI.DisplayStudents();
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Write("Enter Degree Name: ");
                        string degree= Console.ReadLine();
                        DegreeUI.DegreeStudents(degree);
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.Write("Enter the student name: ");
                        string name= Console.ReadLine();
                        if(StudentDL.StudentExists(name)==true)
                        {
                            Console.Write("Enter student name to register in a subject: ");
                            string studentName = Console.ReadLine();
                            Student student = StudentDL.getStudentList().Find(stud => stud.name == studentName);
                            if (student != null)
                            {
                                Degree studentDegree = DegreeDL.GetDegreeList().Find(deg => deg.name == studentName);
                                if (studentDegree != null)
                                {
                                    studentDegree.RegisterStudentSubject(student);
                                    Console.Write("Student Registered...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Student is not registered in any degree.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                        }
                        break;
                    case "7":
                        foreach (Degree degree1 in DegreeDL.GetDegreeList())
                        {
                            degree1.CalculateFee();
                            Console.ReadKey();
                        }
                        break;
                    case "8":
                        condition=false;
                        break;

                    default:
                        
                        break;
                }
            }
        }
    }
}
