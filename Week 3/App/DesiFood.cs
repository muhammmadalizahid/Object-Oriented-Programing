using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class DesiFood
    {
        public DesiFood(string desiname, float desiprice)
        {
            DesiName = desiname;
            DesiPrice = desiprice;
        }
        public string DesiName { get; set; }
        public float DesiPrice { get; set; }
        public void DesiFoodDetails()
        {
            Console.Write("Enter the food item: ");
            DesiName = Console.ReadLine();
            Console.Write("Enter food item's price: ");
            DesiPrice = float.Parse(Console.ReadLine());
        }
        public void DisplayDesiFood()
        {
            Console.WriteLine($"Food: {DesiName}, Price: {DesiPrice}");
        }
    }
}

