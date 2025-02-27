using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.UI;

namespace Task1.DL
{
    internal class StudentDL
    {
        public static List<Student> studentList = new List<Student>();
        public static void AddStudent(Student s)
        {
            studentList.Add(s);
        }
        public static List<Student> getStudentList()
        {
            return studentList;
        }
        public static bool StudentExists(string studentName)
        {
            foreach (Student student in studentList)
            {
                if (student.name == studentName)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
