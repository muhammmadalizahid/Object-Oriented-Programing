using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameproject
{
    internal class Enemy
    {
        public int Ox;
        public int Oy;
        public char[,] Maze;
        public int score;
        public Enemy(char[,] maze, ref int ox, ref int oy)
        {
            Ox = ox;
            Oy = oy;
            Maze = maze;
        }
        public void PrintObstacle()
        {
            Console.SetCursorPosition(Ox, Oy);
            Console.Write(" __________");
            Console.SetCursorPosition(Ox, Oy + 1);
            Console.Write("/|   |    |\\");
        }
        public void RemoveObstacle()
        {
            Console.SetCursorPosition(Ox, Oy);
            Console.Write("           ");
            Console.SetCursorPosition(Ox, Oy + 1);
            Console.Write("            ");
        }
        public void MoveObstacle()
        {
            Ox = 36;
            Oy = 8;
            RemoveObstacle();
            Ox = Ox + 15;
            Oy = Oy + 8;
            PrintObstacle();
        }
    }
}
    
