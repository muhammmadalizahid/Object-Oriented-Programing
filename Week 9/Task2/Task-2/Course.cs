using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.DL
{
    public class Course
    {
        private string CourseName;
        public Course(string CourseName)
        {
            this.CourseName = CourseName;
        }
        public string GetCourseName()
        {
            return CourseName;
        }
        public void SetCourseName(string name)
        {
            CourseName = name;
        }
        public virtual bool Passed()
        {
            return false;
        }
    }
}
