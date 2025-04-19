using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.DL;

namespace Task_2.BL
{
    public class AbsoluteGradedCourse : Course
    {
        private int marks;
        private string grade;

        public AbsoluteGradedCourse(string courseName, int marks) : base(courseName)
        {
            Marks = marks;
        }

        public int Marks
        {
            get { return marks; }
            set
            {
                marks = value;
                grade = CalculateGrade();
            }
        }
        public string Grade => grade;
        private string CalculateGrade()
        {
            if (marks >= 90) return "A";
            else if (marks >= 80) return "B";
            else if (marks >= 70) return "C";
            else if (marks >= 60) return "D";
            else if (marks >= 50) return "E";
            else if (marks >= 40) return "F";
            else return "F";
        }

        public override bool Passed()
        {
            return grade == "A" || grade == "B" || grade == "C" || grade == "D" || grade == "E";
        }
    }

}
