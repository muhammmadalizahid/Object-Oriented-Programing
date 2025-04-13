using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;
namespace Task1.UI
{
    class PersonUI
    {
        public static Person takePersonInfo()
        {
            Console.WriteLine("Enter Person Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address= Console.ReadLine();
            Person person = new Person(name, address);
            Person.addToList(person);
            return person;
        }
    }
}
