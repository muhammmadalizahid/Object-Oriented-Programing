using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.DL;

namespace Task_2.BL
{
    public class Project
    {
        private List<Course> courses;

        public Project(List<Course> courseList)
        {
            courses = courseList;
        }

        public bool Passed()
        {
            int passedCount = 0;

            foreach (Course course in courses)
            {
                if (course.Passed()) passedCount++;
            }

            return passedCount >= 3;
        }
    }

}

