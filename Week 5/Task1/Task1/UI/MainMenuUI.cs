using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.UI
{
    internal class MainMenuUI
    {
        public static string Menu()
        {
            Console.Clear();
            Console.Write("1. Add a Student\n2. Add Degree Program\n3. Generate Merit\n4. View Registered Students\n5. View Students of a specific program\n6. Register subjects for a specific student\n7. Calculate Fees for all registered students.\n8.Exit\nEnter your choice: ");
            string choice= Console.ReadLine();
            return choice;
        }
    }
}
