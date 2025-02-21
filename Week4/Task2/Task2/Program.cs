using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Alice = new Player("Alice", 110, 50, 10);
            Player Bob = new Player("Bob", 100, 60, 20);
            Stats fireball = new Stats("fireball", 23, 1.2F, 5, 15, "a magical attack");
            Alice.learnSkill(fireball);
            Console.WriteLine(Alice.attack(Bob));
            Stats superBeam = new Stats("Super Beam", 200, 50, 50, 75, "an overpowered attack!!!");
            Bob.learnSkill(superBeam);
            Console.WriteLine(Bob.attack(Alice));
        }
    }
}
