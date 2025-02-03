using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        static List<DesiFood> desifoodList = new List<DesiFood>();
        static List<ContinentalFood> continentalfoodList = new List<ContinentalFood>();
        static List<OtherFood> otherfoodList = new List<OtherFood>();
        static List<Employee> employeeList = new List<Employee>();
        static void Main(string[] args)
        {
            
            while (true)
            {
                MainHeader();
                string selection = MainMenu();
                bool checksel = CheckSelection(selection);
                if (selection == "1" && checksel == true) //selection 1 for user
                {
                    while (true)
                    {
                        ContinueToPage();
                        UserHeader();
                        string choice = UserMenu();
                        if (choice == "1")//pressing 1 for menu
                        {
                            Console.WriteLine("\nFood Menu:");
                            Console.WriteLine("DESI FOOD:");
                            foreach (var food in desifoodList)
                            {
                                food.DisplayDesiFood();
                            }
                            Console.WriteLine("CONTINENTAL FOOD:");
                            foreach (var food in continentalfoodList)
                            {
                                food.DisplayContinentalFood();
                            }
                            Console.WriteLine("Other FOOD:");
                            foreach (var food in otherfoodList)
                            {
                                food.DisplayOtherFood();
                            }
                            Console.WriteLine();
                        }
                        else if (choice == "2")//pressing 2 for order
                        {
                            int orderid = 1;
                            orderid++;
                            Console.WriteLine("Your Order ID is:" +orderid);
                            int sum = 0;
                            string domain, order, choice1;
                            bool condition = true;

                            while (condition == true)// input with validation
                            {
                                Console.WriteLine("From which domain would you like to order? (i.e Desi, Chinese, Other): ");
                                Console.WriteLine();
                                domain = Console.ReadLine();
                                bool result = validstring(domain);
                                if (result == true)
                                {
                                    bool result1 = checkdomain(domain);
                                    if (result1 == true)
                                    {
                                        Console.Write("What item would you like to order: ");
                                        order = Console.ReadLine();
                                        bool check = verifyupdateitem(domain, order);
                                        if (check == true)
                                        {
                                            int index = finditemupdate(domain, order);
                                           
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Item name...");
                                            Console.WriteLine("Press any key to try again...");
                                            Console.ReadKey();
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Domain name...");
                                        Console.WriteLine("Press any key to try again...");
                                        Console.ReadKey();
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input...");
                                    Console.WriteLine("Press any key to try again...");
                                    Console.ReadKey();
                                    continue;
                                }
                                Console.WriteLine("Do you want to order more items? (yes or no): ");
                                choice1 = Console.ReadLine();
                                bool result2 = checkchoiceinput(choice1);
                                if (result2 == true)
                                {
                                    bool result3 = checkchoice(choice1);
                                    if (result3 == true)
                                    {
                                        condition = true;
                                    }
                                    else if (result3 == false)
                                    {
                                        condition = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input...");
                                    Console.WriteLine("Press any key to try again...");
                                    Console.ReadKey();
                                }

                            }
                            Console.WriteLine("Your Total Bill is: " + sum);
                        }
                        else if (choice == "3")//back
                        {
                            break;
                        }
                        else if (choice == "4")///exit
                        {
                            Console.Clear();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input...");
                        }
                    }
                }
                else if (selection == "3" && checksel == true)//exit
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else if (selection == "2" && checksel == true)//selection 2 for admin
                {
                    ContinueToPage();
                    LoginHeader();
                    Console.WriteLine();
                    string username, password;
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    password = Console.ReadLine();
                    bool checkpass = checkpassword(username, password);
                    if (checkpass == true)
                    {
                        while (true)
                        {
                            AdminHeader();
                            Console.WriteLine();
                            
                            string decesion = AdminMenu();
                            if (decesion == "1")//entering whole menu
                            {
                                Console.Clear();
                                Console.WriteLine("ENTER TODAY'S MENU: ");
                                Console.Write("How many items do you want to add for Desi Food Menu: ");
                                int count = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                for (int i = 0; i < count; i++)
                                {
                                    Console.WriteLine($"\nEnter details for food item {i + 1}:");
                                    DesiFood desifood = new DesiFood("Default", 0);
                                    desifood.DesiFoodDetails();
                                    desifoodList.Add(desifood);
                                }
                                Console.Write("How many items do you want to add for Continental Food Menu: ");
                                int count1 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                for (int i = 0; i < count1; i++)
                                {
                                    Console.WriteLine($"\nEnter details for food item {i + 1}:");
                                    ContinentalFood continentalfood = new ContinentalFood("Default", 0);
                                    continentalfood.ContinentalFoodDetails();
                                    continentalfoodList.Add(continentalfood);
                                }
                                Console.WriteLine();
                                Console.Write("How many items do you want to add for Others Food Menu: ");
                                int count2 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                for (int i = 0; i < count2; i++)
                                {
                                    Console.WriteLine($"\nEnter details for food item {i + 1}:");
                                    OtherFood otherfood = new OtherFood("Default", 0);
                                    otherfood.OtherFoodDetails();
                                    otherfoodList.Add(otherfood);
                                }
                                Console.WriteLine();
                                Console.WriteLine("\nFood Menu:");
                                Console.WriteLine("DESI FOOD:");
                                foreach (var food in desifoodList)
                                {
                                    food.DisplayDesiFood();
                                }
                                Console.WriteLine("CONTINENTAL FOOD:");
                                foreach (var food in continentalfoodList)
                                {
                                    food.DisplayContinentalFood();
                                }
                                Console.WriteLine("Other FOOD:");
                                foreach (var food in otherfoodList)
                                {
                                    food.DisplayOtherFood();
                                }
                                Console.WriteLine();
                            }
                            else if (decesion == "2")//printing menu
                            {
                                Console.Clear();
                                Console.WriteLine("\nFood Menu:");
                                Console.WriteLine("DESI FOOD:");
                                foreach (var food in desifoodList)
                                {
                                    food.DisplayDesiFood();
                                }
                                Console.WriteLine("CONTINENTAL FOOD:");
                                foreach (var food in continentalfoodList)
                                {
                                    food.DisplayContinentalFood();
                                }
                                Console.WriteLine("Other FOOD:");
                                foreach (var food in otherfoodList)
                                {
                                    food.DisplayOtherFood();
                                }
                                Console.WriteLine();
                                Console.ReadKey();
                            }
                            //else if (decesion == "3")//updating item
                            //{
                            //    string domain = askdomain();
                            //    bool check = checkdomain(domain);
                            //    if (check == true)
                            //    {
                            //        string item = askitem();
                            //        bool verify = verifyupdateitem(domain, item);
                            //        if (verify == true)
                            //        {
                            //            int index = finditemupdate(domain, item);
                            //            string updatedItemname = askupdatedname();
                            //            bool check9 = verifyvaliditem(updatedItemname);
                            //            if (check9 == true)
                            //            {
                            //                string updatedItemprice = askupdatedprice();
                            //                bool check10 = validinputprice(updatedItemprice);
                            //                if (check10 == true)
                            //                {
                            //                    updateitem(index, domain, updatedItemname, updatedItemprice);
                            //                }
                            //                else if (check10 == false)
                            //                {
                            //                    Console.WriteLine("Invalid Input, Please do not enter alphabets or special characters...");
                            //                    Console.WriteLine("Press any key to try again...");
                            //                    Console.ReadKey();

                            //                }
                            //            }
                            //            else if (check9 == false)
                            //            {
                            //                Console.WriteLine("Invalid Input, Please do not enter numbers or special characters...");
                            //                Console.WriteLine("Press any key to try again...");
                            //                Console.ReadKey();
                            //            }
                            //        }
                            //        else
                            //        {
                            //            Console.WriteLine("Invalid Input, item does not exist in the Menu, try again...");
                            //            Console.WriteLine("Press any key to return...");
                            //            Console.ReadKey();
                            //        }
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Invalid Input, domain does not exist. Try Again!");
                            //        Console.WriteLine("Press any key to continue.");
                            //        Console.ReadKey();
                            //    }
                            //}
                            //else if (decesion == "4")//deleting item
                            //{
                            //    string domain = askdomaindel();
                            //    bool check = checkdomain(domain);
                            //    if (check == true)
                            //    {
                            //        string item = askitemdel();
                            //        bool verify = verifyupdateitem(domain, item);
                            //        if (verify == true)
                            //        {
                            //            finditemdel(domain, item);
                            //            Console.WriteLine("The item has been deleted...");
                            //            Console.WriteLine("Press any key to return...");
                            //            Console.ReadKey();
                            //        }
                            //        else
                            //        {
                            //            Console.WriteLine("Invalid Input, item does not exist in the Menu, try again...");
                            //            Console.WriteLine("Press any key to return...");
                            //            Console.ReadKey();
                            //        }
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Invalid Input, domain does not exist. Try Again!");
                            //        Console.WriteLine("Press any key to continue.");
                            //        Console.ReadKey();
                            //    }
                            //}
                            //else if (decesion == "5")//new item
                            //{
                            //    string domain = askdomain();
                            //    bool check = checkdomain(domain);
                            //    if (check == true)
                            //    {
                            //        string number;
                            //        Console.WriteLine("How many items do you want to add? ");
                            //        number = Console.ReadLine();
                            //        bool result = validnumber(number);
                            //        if (result == true)
                            //        {
                            //            int num = checknumber(number);
                            //            if (num == 0)
                            //            {
                            //                Console.WriteLine("Invalid Input...Not an Entry...");
                            //                Console.WriteLine("Press any key to return...");
                            //                Console.ReadKey();

                            //            }
                            //            else
                            //            {
                            //                if (domain == "continental" || domain == "Continental")
                            //                {
                            //                    newcontinental(num);
                            //                    char ch = itemadded();
                            //                }
                            //                else if (domain == "desi" || domain == "Desi")
                            //                {
                            //                    newdesi(num);
                            //                    char ch = itemadded();
                            //                }
                            //                else if (domain == "other" || domain == "other")
                            //                {
                            //                    newother(num);
                            //                    char ch = itemadded();
                            //                }
                            //            }
                            //        }
                            //        else
                            //        {
                            //            Console.WriteLine("Invalid Input, please enter number only.");
                            //            Console.WriteLine("Press any key to continue.");
                            //            Console.ReadKey();
                            //        }
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Invalid Input, domain does not exist. Try Again!");
                            //        Console.WriteLine("Press any key to continue.");
                            //        Console.ReadKey();
                            //    }


                            //}
                            else if (decesion == "6")//employee deatils
                            {
                                Console.Write("How many Employees do you want to add: ");
                                int count = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                for (int i = 0; i < count; i++)
                                {
                                    Console.WriteLine($"\nEnter details for Employee {i + 1}:");
                                    Employee employee= new Employee("Default", "Default", "Default", "Default");
                                    employee.EmployeeDetails();
                                    employeeList.Add(employee);
                                }
                            }
                            else if (decesion == "7")//printing employee details
                            {
                                Console.WriteLine("Employee Details: ");
                                foreach (var employee in employeeList)
                                {
                                    employee.DisplayEmployee();
                                }
                            }
                            //else if (decesion == "8")//updating employee
                            //{
                            //    string name = askemployeeupdate();
                            //    bool check1 = verifyemployee(name);
                            //    if (check1 == true)
                            //    {
                            //        int index = findemployeeupdate(name);
                            //        updateemployee(index);
                            //        Console.WriteLine();
                            //        printemployeedetails();
                            //    }
                            //    else if (check1 == false)
                            //    {
                            //        Console.WriteLine("Invalid Input... Employee not found....");
                            //        Console.WriteLine("Press any key to return...");
                            //        Console.ReadKey();
                            //    }
                            //}
                            //else if (decesion == "9")//deleting employee
                            //{
                            //    string name = askemployeedelete();
                            //    bool check = verifyemployee(name);
                            //    if (check == true)
                            //    {
                            //        int index = findemployeedelete(name);
                            //        deleteemployee(index);
                            //        Console.WriteLine();
                            //        printemployeedetails();
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Invalid Input... Employee not found....");
                            //        Console.WriteLine("Press any key to return...");
                            //        Console.ReadKey();
                            //    }
                            //}
                            //else if (decesion == "10")//new employee
                            //{
                            //    string number;
                            //    Console.WriteLine("How many employees do you want to add? ");
                            //    number = Console.ReadLine();
                            //    bool result = validnumber(number);
                            //    if (result == true)
                            //    {
                            //        int num = checknumber(number);
                            //        if (num == 0)
                            //        {
                            //            Console.WriteLine("Invalid Input...Not an Entry...");
                            //            Console.WriteLine("Press any key to return...");
                            //            Console.ReadKey();
                            //        }
                            //        else
                            //        {
                            //            asknewemployeedeatils(num);
                            //            Console.WriteLine("Employee added sucessfully!");
                            //            Console.WriteLine("Press any key to return...");
                            //            Console.ReadKey();
                            //        }
                            //    }
                            //}
                            //else if (decesion == "11")//displaying order history
                            //{
                            //    Console.WriteLine("Press any key to continue...");
                            //    Console.ReadKey();
                            //}
                            else if (decesion == "12")//back
                            {
                                break;
                            }
                            else if (decesion == "13")//exit
                            {
                                Console.Clear();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input...");
                                Console.WriteLine("Press any key to try again...");
                                Console.ReadKey();
                                continue;
                            }
                        }
                    }

                    else if (checkpass == false)
                    {
                        Console.WriteLine("Invalid Username or Password!");
                        Console.WriteLine("Press any key to go back to the main menu.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input...");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                }
            }
        }
        static string MainMenu()
        {
            int x = 81, y = 25;
            string selection;
            Console.WriteLine("1: Customer");
            Console.WriteLine("2: Administrator");
            Console.WriteLine("3: Exit Application");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            selection = Console.ReadLine();
            return selection;
        }
        static void ContinueToPage()
        {
            Console.WriteLine("Press any key to continue to the next page: ");
            Console.ReadKey();
        }
        static void MainHeader()
        {
            Console.Clear();
            Console.WriteLine( "         ####### ####### ####### ####### ######## ###### #######  ######## #######");
            Console.WriteLine( "         ##      ##   ## ##      ##         ##    ##     ##   ###    ##    ##   ##");
            Console.WriteLine( "         ##      ####### ######  #######    ##    ###### ######      ##    #######");
            Console.WriteLine( "         ##      ##   ## ##      ##         ##    ##     ##   ##     ##    ##   ##");
            Console.WriteLine( "         ####### ##   ## ##      #######    ##    ###### ##    ## ######## ##   ##");
            Console.WriteLine( "##     ## ####### ###     ## ####### ######## ####### ##     ## ####### ###    ## ########");
            Console.WriteLine( "## ### ## ##   ## ## ##   ## ##   ## ##       ##      ## ### ## ##      ## ##  ##    ##");
            Console.WriteLine( "##  #  ## ####### ##   ## ## ####### ##  #### ####### ##  #  ## ####### ##  ## ##    ##");
            Console.WriteLine( "##     ## ##   ## ##     ### ##   ## ##    ## ##      ##     ## ##      ##    ###    ##");
            Console.WriteLine( "##     ## ##   ## ##      ## ##   ## ######## ####### ##     ## ####### ##     ##    ##");
            Console.WriteLine( "                  ######## ##    ## ######## ######## ####### ##     ##");
            Console.WriteLine( "                  ##        ##  ##  ##          ##    ##      ## ### ##");
            Console.WriteLine( "                  ########    ##    ########    ##    ####### ##  #  ##");
            Console.WriteLine( "                        ##    ##          ##    ##    ##      ##     ##");
            Console.WriteLine( "                  ########    ##    ########    ##    ####### ##     ##"); 
        }
        static void UserHeader()
        {
                Console.Clear();
                Console.WriteLine("HH   HH EEEEEE LL     LL      OOOOO     DDDDD   EEEEEE AAAAAAA RRRRR     CCCCCC UU    UU  SSSSS TTTTTTTT  OOOOO  MN    MM EEEEEE RRRRR ");
                Console.WriteLine("HH   HH EE     LL     LL     OO   OO    DD   DD EE     AA   AA RR  RR   CC      UU    UU SS        TT    OO   OO MMM  MMM EE     RR  RR");
                Console.WriteLine("HHHHHHH EEEEEE LL     LL     OO   OO    DD   DD EEEEEE AAAAAAA RRRRR    CC      UU    UU   SSSS    TT    OO   OO MM MM MM EEEEEE RRRRR");
                Console.WriteLine("HH   HH EE     LL     LL     OO   OO    DD   DD EE     AA   AA RR  RR   CC      UU    UU      SS   TT    OO   OO MM    MM EE     RR  RR");
                Console.WriteLine("HH   HH EEEEEE LLLLLL LLLLLL  OOOOO     DDDDD   EEEEEE AA   AA RR   RR    CCCCC  UUUUUU   SSSSS    TT     OOOOO  MM    MM EEEEEE RR   RR");
            
        }
        static string UserMenu()
        {
            int x = 82, y = 15;
            string choice;
            Console.WriteLine( "1: See Whole Menu");
            Console.WriteLine( "2: Order");
            Console.WriteLine( "3: Back");
            Console.WriteLine( "4: Exit Application");
            Console.WriteLine( "Enter your choice: ");
            choice = Console.ReadLine();
            return choice;
        }
        static void AdminHeader()
        {
            Console.Clear();
            Console.WriteLine( "                                   AA   DDDDD   MM    MM IIIIII NN    NN    IIIIIIII NN    NN TTTTTTTT EEEEEE RRRRR   FFFFFF   AAA    CCCCC EEEEEE");
            Console.WriteLine( "                                 AA  AA DD   DD MMM  MMM   II   NNN   NN       II    NNN   NN    TT    EE     RR   RR FF     AA   AA CC     EE    ");
            Console.WriteLine( "                                 AAAAAA DD   DD MM MM MM   II   NN NN NN       II    NN NN NN    TT    EEEEEE RRRRR   FFFFFF AAAAAAA CC     EEEEEE");
            Console.WriteLine( "                                 AA  AA DD   DD MM    MM   II   NN   NNN       II    NN   NNN    TT    EE     RR  RR  FF     AA   AA CC     EE    ");
            Console.WriteLine( "                                 AA  AA DDDDD   MM    MM IIIIII NN    NN    IIIIIIII NN    NN    TT    EEEEEE RR   RR FF     AA   AA  CCCCC EEEEEE");
        }
        static string AdminMenu()
        {
            int x = 74, y = 14;
            Console.WriteLine( " 1: Enter Whole Menu");
            Console.WriteLine( " 2: See Whole Menu");
            Console.WriteLine( " 3: Update Item From Menu");
            Console.WriteLine( " 4: Delete Item From Menu");
            Console.WriteLine( " 5: Enter New Item in Menu");
            Console.WriteLine( " 6: Enter Whole Employee Record");
            Console.WriteLine( " 7: See Employee Record");
            Console.WriteLine( " 8: Update Employee's Record");
            Console.WriteLine( " 9: Delete Employee's Record");
            Console.WriteLine( "10: Add New Employee");
            Console.WriteLine( "11: See Order History");
            Console.WriteLine( "12: Back");
            Console.WriteLine( "13: Exit Application");
            string n;
            Console.WriteLine( "Enter your choice: ");
            n = Console.ReadLine();
            return n;
        }
        static void LoginHeader()
        {
            Console.Clear();
            Console.WriteLine("****************************************************************************************************************************************************************************");
            Console.WriteLine("*                                                                               LOGIN PAGE                                                                                 *");
            Console.WriteLine("****************************************************************************************************************************************************************************");
        }
        static bool CheckSelection(string selection)
        {
            if (selection == "1" || selection == "2" || selection == "3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool validstring(string input)//string validation check
        {
            for (int i = 0; input[i] != '\0'; i++)
            {
                char c = input[i];
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ') || c == '\\' || c == '/')
                {
                    return false;
                }
            }
            return true;
        }
        static bool validnumber(string input) //valid number check
        {
            for (int i = 0; input[i] != '\0'; i++)
            {
                char c = input[i];
                if (!(c >= '0' && c <= '9'))
                {
                    return false;
                }
            }
            return true;
        }
        static bool checkdomain(string domain)//input validation
        {
            if (domain == "Desi" || domain == "desi" || domain == "Continental" || domain == "continental" || domain == "other" || domain == "Other")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool verifyupdateitem(string domain, string item)
        {
            if (domain == "Desi" || domain == "desi")
            {
                for (int i = 0; i < desifoodList.Count; i++)
                {
                    if (desifoodList[i].DesiName == item)
                    {
                        return true;
                    }
                }
            }
            else if (domain == "Continental" || domain == "continental")
            {
                for (int i = 0; i < continentalfoodList.Count; i++)
                {
                    if (continentalfoodList[i].ContinentalName == item)
                    {
                        return true;
                    }
                }
            }
            else if (domain == "other" || domain == "Other")
            {
                for (int i = 0; i < otherfoodList.Count; i++)
                {
                    if (otherfoodList[i].OtherName == item)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }
        static int finditemupdate(string domain, string item)
        {
            int index = -1; 
            if (domain == "Desi" || domain == "desi")
            {
                for (int i = 0; i < desifoodList.Count; i++)
                {
                    if (desifoodList[i].DesiName == item)
                    {
                        index = i;
                        return index;
                    }
                }
            }
            else if (domain == "Continental" || domain == "continental")
            {
                for (int i = 0; i < continentalfoodList.Count; i++)
                {
                    if (continentalfoodList[i].ContinentalName == item)
                    {
                        index = i;
                        return index;
                    }
                }
            }
            else if (domain == "other" || domain == "Other")
            {
                for (int i = 0; i < otherfoodList.Count; i++)
                {
                    if (otherfoodList[i].OtherName == item)
                    {
                        index = i;
                        return index;
                    }
                }
            }
            return index;
        }
        static bool checkchoiceinput(string choice)
        {
            if (choice == "yes" || choice == "Yes" || choice == "no" || choice == "No")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool checkchoice(string choice)
        {
            if (choice == "yes" || choice == "Yes")
            {
                return true;
            }
            else if (choice == "no" || choice == "No")
            {
                return false;
            }
            else
            {
                return false;
            }

        }
        static bool checkpassword(string admin, string password)
        {
            string filePath = "E:\\OOP\\game\\app\\app\\credentials.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: Could not open the file!");
                return false;
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 2)
            {
                Console.WriteLine("Error: Invalid file format!");
                return false;
            }

            string storedUsername = lines[0];
            string storedPassword = lines[1];

            return (admin == storedUsername && password == storedPassword);
        }

    }
}

