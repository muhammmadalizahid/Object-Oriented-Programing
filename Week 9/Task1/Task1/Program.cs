using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Enter Project Name: ");
            string projectName = Console.ReadLine();
            List<string> courses = new List<string>();
            for (int i = 1; i <= 2; i++)
            {
                Console.Write($"Enter Course{i} Name (Absolute Graded): ");
                string courseName = Console.ReadLine();
                courses.Add(courseName);

                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                string grade = absoluteGrade(marks);
                Console.WriteLine($"Grade: {grade}\n");
                AbsoluteGradedCourse g = new AbsoluteGradedCourse(courseName, marks, grade);
                bool result = g.passed();
                if(result== true)
                {
                    count++;
                }
            }
            for (int i = 3; i <= 4; i++)
            {
                Console.Write($"Enter Course{i} Name (Graded): ");
                string courseName = Console.ReadLine();
                courses.Add(courseName);

                Console.Write("Enter Grade Point: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                string grade1 = grade(marks);
                Console.WriteLine($"Grade: {grade1}\n");
                GradedCourse g1 = new GradedCourse(courseName, marks, grade1);
                bool result = g1.passed();
                if (result == true)
                {
                    count++;
                }
            }
            if(count>=1)
            {
                Console.WriteLine("You have passed the project");
            }
            else
            {
                Console.WriteLine("You have failed the project");
            }
        }
        public static string grade(int marks)
        {
            if (marks!=12 && marks != 10 && marks != 7 && marks != 4 && marks != 2 && marks != 0 && marks!=-2)
            {
                return "invalid marks entered";
            }
            else if (marks==12)
            {
                return "100-90";
            }
            else if (marks == 10)
            {
                return "89-80";
            }
            else if (marks == 7)
            {
                return "79-70";
            }
            else if (marks == 4)
            {
                return "69-60";
            }
            else if (marks == 2)
            {
                return "59-50";
            }
            else if (marks == 0)
            {
                return "49-40";
            }
            else if(marks == -2)
            {
                return "39-0";
            }
            else
            {
                return "invalid marks entered";
            }
        }
        public static string absoluteGrade(int marks)
        {
            if(marks>100 || marks<0)
            {
                return "invalid marks entered";
            }
            else if(marks>=90)
            {
                return "A+";
            }
            else if(marks>=80)
            {
                return "A";
            }
            else if(marks>=70)
            {
                return "B";
            }
            else if(marks>=60)
            {
                return "C";
            }
            else if(marks>=50)
            {
                return "D";
            }
            else if(marks<=49)
            {
                return "F";
            }
            else
            {
                return "invalid marks entered";
            }
        }
    }
}
