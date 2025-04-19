using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Task_2.BL;
using Task_2.DL;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Course ag = new AbsoluteGradedCourse("English", 75);
            Course ag1 = new AbsoluteGradedCourse("Urdu", 75);
            Course g  = new GradedCourse("Math", 10);
            Course g1  = new GradedCourse("Physics", 7);
            List<Course> Courses = new List<Course> { ag, ag1, g, g1 };
            Project project = new Project(Courses);
            Console.WriteLine("Result: \n");
            if (project.Passed())
            { 
                Console.WriteLine("Project Passed!");
            }
            else
            {
                Console.WriteLine("Project Failed!");
            }
                
        }
    }
}
