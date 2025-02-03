using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class OtherFood
    {
        public OtherFood(string othername, float otherprice)
        {
            OtherName = othername;
            OtherPrice = otherprice;
        }
        public string OtherName { get; set; }
        public float OtherPrice { get; set; }
        public void OtherFoodDetails()
        {
            Console.Write("Enter the food item: ");
            OtherName = Console.ReadLine();
            Console.Write("Enter food item's price: ");
            OtherPrice = float.Parse(Console.ReadLine());

        }
        public void DisplayOtherFood()
        {
            Console.WriteLine($"Food: {OtherName}, Price: {OtherPrice}");
        }
    }
}
