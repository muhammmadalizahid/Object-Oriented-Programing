using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.UI;
using Task2.DL;
using Task2.BL;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string selection = AdminUI.MainMenu();
                if (selection == "1")
                {
                    Admin admin=AdminUI.AdminMenu();
                    bool condition = true;
                    while (condition)
                    {
                        Console.Clear();
                        string choice = ProductUI.ProductMenu();
                        switch (choice)
                        {
                            case "1":
                                Product product = ProductUI.TakeProductInfo();
                                ProductDL.AddProduct(product);
                                break;
                            case "2":
                                ProductUI.DisplayProducts();
                                break;
                            case "3":
                                ProductUI.ExpensiveProduct();
                                break;
                            case "4":
                                ProductUI.DisplaySalesTax();
                                break;
                            case "5":
                                ProductUI.ProductsToOrder();
                                break;
                            case "7":
                                condition = false;
                                break;
                            default:
                                Console.Write("Invalid Input...");
                                break;
                        }
                    }
                }
                else if (selection == "2")
                {
                    bool condition = true;
                    Customer customer = null;
                    while (condition)
                    {
                        Console.Clear();
                        Customer cus = CustomerUI.CustomerCheck();
                        string choice = CustomerUI.CustomerMenu();
                        switch (choice)
                        {
                            case "1":
                                CustomerUI.ViewAllProducts();
                                break;
                            case "2":
                                CustomerDL.AddCustomer(customer);
                                CustomerUI.BuyProduct(customer);
                                break;
                            case "3":
                                if (customer != null)
                                {
                                    CustomerUI.GenerateInvoice(customer);
                                }
                                else
                                {
                                    Console.WriteLine("No customer selected.");
                                }
                                break;
                            case "5":
                                condition = false;
                                break;
                            default:
                                Console.Write("Invalid Input...");
                                break;
                        }
                    }
                    
                }
                else if(selection=="3")
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid Input...");
                }
            }
        }
    }
}
