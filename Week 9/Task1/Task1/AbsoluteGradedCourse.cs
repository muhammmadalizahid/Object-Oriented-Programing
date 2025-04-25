using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class AbsoluteGradedCourse:Project
    {
        private string courseName;
        private int marks;
        private string grade;
        public AbsoluteGradedCourse(string courseName, int marks, string grade)
        {
            this.courseName = courseName;
            this.marks = marks;
            this.grade = grade;
        }
        public void setCourseName(string courseName)
        {
            this.courseName = courseName;
        }
        public string getCourseName()
        {
            return courseName;
        }
        public void setMarks(int marks)
        {
            this.marks = marks;
        }
        public int getMarks()
        {
            return marks;
        }
        public void setGrade(string grade)
        {
            this.grade = grade;
        }
        public string getGrade()
        {
            return grade;
        }
        public override bool passed()
        {
            if(grade=="F")
            {
                return false;
            }
            return true;

        }
    }
}
