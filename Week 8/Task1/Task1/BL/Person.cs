using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Person
    {
        private string name;
        private string address;
        public string Name
        {
            get { return name; }
            set { name = value;  }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public virtual string toString()
        {
            return "";  
        }
        public static void addToList(Person person)
        {
            DL.PersonDL.personList.Add(person);
        }
    }
}
