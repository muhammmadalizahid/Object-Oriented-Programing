using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Subject
    {
        public string code;
        public int creditHours;
        public string type;
        public float subjectFee;
        public Subject()
        {

        }
        public Subject(string code, int creditHours, string type, float subjectFee)
        {
            this.code = code;
            this.creditHours = creditHours;
            this.type = type;
            this.subjectFee = subjectFee;
        }
    }
}
