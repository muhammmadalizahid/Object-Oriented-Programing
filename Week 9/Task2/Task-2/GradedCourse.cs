using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.DL;

namespace Task_2.BL
{
    public class GradedCourse : Course
    {
        private int grade;

        public GradedCourse(string courseName, int grade) : base(courseName)
        {
            Grade = grade;
        }
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override bool Passed()
        {
            return Grade >= 2;
        }
    }

}
