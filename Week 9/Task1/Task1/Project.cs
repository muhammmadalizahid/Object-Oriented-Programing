using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Project
    {
        public string projectName;
        public List<string> courses;
        public Project()
        {

        }
        public Project(string projectName, List<string> courses)
        {
            this.projectName = projectName;
            this.courses = courses;
        }
        public virtual bool passed()
        {
            return true;
        }
        public void setProjectName(string projectName)
        {
            this.projectName = projectName;
        }
        public string getProjectName()
        {
            return projectName;
        }
        public void setCourses(List<string> courses)
        {
            this.courses = courses;
        }
        public List<string> getCourses()
        {
            return courses;
        }
        public void addCourse(string course)
        {
            courses.Add(course);
        }
        public void removeCourse(string course)
        {
            courses.Remove(course);
        }
        public void displayCourses()
        {
            Console.WriteLine("Courses in the project:");
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
