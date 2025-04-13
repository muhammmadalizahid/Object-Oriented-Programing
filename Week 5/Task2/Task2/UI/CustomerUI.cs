using System;
using System.Collections.Generic;
using Task2.BL;
using Task2.DL;

namespace Task2.UI
{
    internal class CustomerUI
    {
        public static Customer CustomerCheck()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1: Sign Up\n2: Sign In\n3: Exit");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    Console.Write("Enter Contact Number: ");
                    string contactNumber = Console.ReadLine();

                    if (CustomerDL.SignUp(username, password, email, address, contactNumber))
                    {
                        continue;
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    Customer customer = CustomerDL.SignIn(username, password);
                    if (customer != null)
                    {
                        return customer;
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
        public static string CustomerMenu()
        {
            Console.WriteLine("1: View All Products\n2.Buy the Products\n3.Generate Invoice\n4. View Profile\n5. Exit");
            string choice = Console.ReadLine();
            return choice;
        }

        public static void ViewAllProducts()
        {
            List<Product> products = ProductDL.GetProductList();
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\nAvailable Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.name}\tCategory: {product.type}\tPrice: {product.price}\tQuantity: {product.quantity}");
            }
        }

        public static void BuyProduct(Customer customer)
        {
            Console.Write("Enter product name to buy: ");
            string productName = Console.ReadLine();
            Console.Write("Enter quantity to buy: ");
            int quantity = int.Parse(Console.ReadLine());
            List<Product> products = ProductDL.GetProductList();
            Product selectedProduct = null;

            foreach (Product p in products)
            {
                if (p.name == productName)
                {
                    selectedProduct = p;
                    break;
                }
            }

            if (selectedProduct == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            if (selectedProduct.quantity < quantity)
            {
                Console.WriteLine("Not enough stock available.");
                return;
            }

            selectedProduct.quantity -= quantity;
            customer.AddToCart(selectedProduct, quantity);
        }
        public static void GenerateInvoice(Customer customer)
        {
            if (customer.cart.Count == 0)
            {
                Console.WriteLine("No products in cart.");
                return;
            }

            float grandTotal = 0;
            foreach (var product in customer.cart)
            {
                float taxRate = 0.15f;
                if (product.type == "grocery")
                {
                    taxRate = 0.10f;
                }
                else if (product.type == "fruit")
                {
                    taxRate = 0.05f;
                }
                float taxAmount = product.price * taxRate;
                float totalPrice = (product.price + taxAmount) * product.quantity;
                Console.WriteLine($"Name: {product.name}\tQuantity: {product.quantity}\tPrice: {product.price}\tTax: {taxAmount}\tTotal Price: {totalPrice}");
                grandTotal += totalPrice;
            }
            Console.WriteLine("Total Amount to Pay: " + grandTotal);
        }
    }
}
