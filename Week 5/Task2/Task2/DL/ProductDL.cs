using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.DL
{
    internal class ProductDL
    {
        public static List<Product> productList=new List<Product>();
        public static void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public static List<Product> GetProductList()
        {
            return productList;
        }

    }
}
