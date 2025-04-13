using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Enter Student");
                Console.WriteLine("2. Enter Staff");
                Console.WriteLine("3. Enter Person");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Exit");
                Console.Write("Choose Option");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        UI.StudentUI.takeStudentInfo();
                        break;
                    case "2":
                        UI.StaffUI.takeStaffInfo();
                        break;
                    case "3":
                        UI.PersonUI.takePersonInfo();
                        break;
                    case "4":
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();
                        foreach (Person person in PersonDL.personList)
                        {
                            if (name == person.Name)
                            {
                                Console.WriteLine(person.toString());
                            }
                            else
                            {
                                Console.WriteLine("Person not found");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
