using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;
using Task2.DL;

namespace Task2.UI
{
    internal class AdminUI
    {
        public static string MainMenu()
        {
            Console.Write("You want to excess the Program as:\n1: Admin\n2: Customer\n3. Exit\nEnter your choice: ");
            string choice = Console.ReadLine();
            return choice;
        }
        public static Admin AdminMenu()
        {
        while (true)
        {
            Console.WriteLine("1: Sign Up\n2: Sign In\n3: Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Admin Username: ");
                string username = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (AdminDL.SignUp(username, password))
                {
                    continue;
                }
            }
            else if (choice == "2")
            {
                Console.Write("Enter Admin Username: ");
                string username = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                Admin admin = AdminDL.SignIn(username, password);
                if (admin != null)
                {
                    return admin;
                }
            }
            else if (choice == "3")
            {
                return null;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
        }
        }
}

