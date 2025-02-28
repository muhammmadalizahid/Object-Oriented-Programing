using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.UI;

namespace Task1.DL
{
    internal class DegreeDL
    {
        public static List<Degree> degreeList = new List<Degree>();
        public static void AddDegree(Degree d)
        {
            degreeList.Add(d);
        }
        public static List<Degree> GetDegreeList()
        {
            return degreeList;
        }
    }
}
