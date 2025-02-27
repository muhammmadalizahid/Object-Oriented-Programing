using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Product
    {
        public string name;
        public float price;
        public string type;
        public int quantity;
        public int threshold;
        public Product()
        {

        }
        public Product(string name, float price, string type, int quantity, int threshold)
        {
            this.name = name;
            this.price = price;
            this.type = type;
            this.quantity = quantity;
            this.threshold = threshold;
        }
    }
}
