using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Customer
    {
        public string username { get; private set; }
        public string password { get; private set; }
        public string email { get; private set; }
        public string address { get; private set; }
        public string contactNumber { get; private set; }
        public List<Product> cart { get; private set; }

        public Customer(string username, string password, string email, string address, string contactNumber)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
            this.contactNumber = contactNumber;
            cart = new List<Product>();
        }
        public void AddToCart(Product product, int quantity)
        {
            cart.Add(new Product(product.name, product.price, product.type, quantity, product.threshold));
        }
        public float CalculateTotalBill()
        {
            float total = 0;
            foreach (var product in cart)
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
                total = total+ (product.price + taxAmount) * product.quantity;
            }
            return total;
        }
    }
    
}
