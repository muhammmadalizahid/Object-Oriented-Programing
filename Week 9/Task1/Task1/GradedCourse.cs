using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GradedCourse:Project
    {
        private string courseName;
        private int scale;
        private string percentage;
        public GradedCourse(string courseName, int scale, string percentage)
        {
            this.courseName = courseName;
            this.scale = scale;
            this.percentage = percentage;
        }
        public void setCourseName(string courseName)
        {
            this.courseName = courseName;
        }
        public string getCourseName()
        {
            return courseName;
        }
        public void setScale(int scale)
        {
            this.scale = scale;
        }
        public int getScale()
        {
            return scale;
        }
        public void setPercentage(string percentage)
        {
            this.percentage = percentage;
        }
        public string getPercentage()
        {
            return percentage;
        }
        public override bool passed()
        {
            if(percentage=="39-0" || percentage=="49-40")
            {
                return false;
            }
            return true;
        }

    }
}
