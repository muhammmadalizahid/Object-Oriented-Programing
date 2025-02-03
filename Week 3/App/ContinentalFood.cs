using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class ContinentalFood
    {
        public ContinentalFood(string continentalname, float continentalprice)
        {
            ContinentalName = continentalname;
            ContinentalPrice = continentalprice;
        }
        public string ContinentalName { get; set; }
        public float ContinentalPrice { get; set; }
        public void ContinentalFoodDetails()
        {
            Console.Write("Enter the food item: ");
            ContinentalName = Console.ReadLine();
            Console.Write("Enter food item's price: ");
            ContinentalPrice = float.Parse(Console.ReadLine());
        }
        public void DisplayContinentalFood()
        {
            Console.WriteLine($"Food: {ContinentalName}, Price: {ContinentalPrice}");
        }
    }
}
