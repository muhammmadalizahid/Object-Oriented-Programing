using System;
using System.Collections.Generic;
using System.Linq;
using Task2.BL;
using Task2.DL;

namespace Task2.UI
{
    internal class ProductUI
    {
        public static string ProductMenu()
        {
            Console.Write("1. Add Product\n2. View All Products\n3. Find Product with highest unit price\n4. View Sales Tax of all products\n5. Products to be ordered\n6. View Profile\n7. Exit\nEnter your choice: ");
            string choice = Console.ReadLine();
            return choice;
        }
        public static Product TakeProductInfo()
        {
            Console.Write("Enter the name of the product: ");
            string name = Console.ReadLine();
            Console.Write("Enter price of the product: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Enter the category of the product: ");
            string type = Console.ReadLine();
            Console.Write("Enter the stock quantity of the product: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter the minimum quantity after which you want reminder to add more: ");
            int threshold = int.Parse(Console.ReadLine());
            return new Product(name, price, type, quantity, threshold);
        }
        public static void DisplayProducts()
        {
            List<Product> products = ProductDL.GetProductList();
            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
            }
            else
            {
                foreach (var p in products)
                {
                    Console.WriteLine($"Name: {p.name}\tPrice: {p.price}\tCategory: {p.type}\tStock: {p.quantity}\tMinimum Threshold: {p.threshold}\n");
                }
            }
        }
        public static void ExpensiveProduct()
        {
            List<Product> products = ProductDL.GetProductList();
            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }
            Product maxProduct = products[0];
            foreach (Product p in products)
            {
                if (p.price > maxProduct.price)
                {
                    maxProduct = p;
                }
            }
            Console.WriteLine("\nProduct with the highest price:");
            Console.WriteLine($"Name: {maxProduct.name}\nPrice: {maxProduct.price}\nCategory: {maxProduct.type}\nStock: {maxProduct.quantity}\nMinimum Threshold: {maxProduct.threshold}\n");
        }
        public static void DisplaySalesTax()
        {
            List<Product> products = ProductDL.GetProductList();
            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }
            foreach (var product in products)
            {
                float taxRate = 0;
                if (product.type == "grocery")
                {
                    taxRate = 0.10f;
                }
                else if (product.type == "fruit")
                {
                    taxRate = 0.05f;
                }
                else
                {
                    taxRate = 0.15f;
                }
                float salesTax = product.price * taxRate;
                Console.WriteLine($"Name: {product.name}\tType: {product.type}\tPrice: {product.price}\tTax: {salesTax}");
            }
        }
        public static void ProductsToOrder()
        {
            List<Product> products = ProductDL.GetProductList();
            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }
            bool found = false;
            foreach (var product in products)
            {
                if (product.quantity < product.threshold)
                {
                    Console.WriteLine($"Name: {product.name}\tCategory: {product.type}\tQuantity: {product.quantity}\tThreshold: {product.threshold}");
                    found = true;
                }
            }
            if (found==false)
            {
                Console.WriteLine("All products are above the threshold. No need to reorder.");
            }
        }
    }
}
