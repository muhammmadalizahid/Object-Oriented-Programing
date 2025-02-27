using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.DL
{
    
    internal class CustomerDL
    {
        private static List<Customer> customerList = new List<Customer>();

        public static bool SignUp(string username, string password, string email, string address, string contactNumber)
        {
            foreach (Customer customer in customerList)
            {
                if (customer.username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("username already taken. Please choose another.");
                    return false;
                }
            }
            customerList.Add(new Customer(username, password, email, address, contactNumber));
            Console.WriteLine("Sign-up successful! You can now log in.");
            return true;
        }

        public static Customer SignIn(string username, string password)
        {
            foreach (Customer customer in customerList)
            {
                if (customer.username == username && customer.password == password)
                {
                    Console.WriteLine($"Welcome back, {customer.username}!");
                    return customer;
                }
            }

            Console.WriteLine("Invalid username or password.");
            return null;
        }
        public static void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }
        public static List<Customer> GetCustomers()
        {
            return customerList;
        }
    }
}


