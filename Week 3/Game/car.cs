using System;

internal class Car
{
    public char[,] Maze;
    public int Px;
    public int Py;
    public Car(char[,] maze, ref int px, ref int py)
    {
        Maze = maze;
        Px = px;
        Py = py;
    }
    public void PrintCar()
    {
        Console.SetCursorPosition(Px, Py);
        Console.Write("   ______");
        Console.SetCursorPosition(Px, Py + 1);
        Console.Write("  /o    o\\");
        Console.SetCursorPosition(Px, Py + 2);
        Console.Write("-| ______ |-");
        Console.SetCursorPosition(Px, Py + 3);
        Console.Write(" | \\____/ |");
        Console.SetCursorPosition(Px, Py + 4);
        Console.Write(" |  ____  |");
        Console.SetCursorPosition(Px, Py + 5);
        Console.Write(" | /____\\ |");
        Console.SetCursorPosition(Px, Py + 6);
        Console.Write("  \\o____o/");
    }
    public void EraseCar()
    {
        Console.SetCursorPosition(Px, Py);
        Console.Write("         ");
        Console.SetCursorPosition(Px, Py + 1);
        Console.Write("           ");
        Console.SetCursorPosition(Px, Py + 2);
        Console.Write("            ");
        Console.SetCursorPosition(Px, Py + 3);
        Console.Write("            ");
        Console.SetCursorPosition(Px, Py + 4);
        Console.Write("           ");
        Console.SetCursorPosition(Px, Py + 5);
        Console.Write("            ");
        Console.SetCursorPosition(Px, Py + 6);
        Console.Write("            ");
    }
    public void MoveCarRight()
    {
        if (Px + 15 < 90 && Maze[Py, Px + 15] == ' ')
        {
            EraseCar();
            Px += 15;
            PrintCar();
        }
    }
    public void MoveCarLeft()
    {
        if (Px - 15 >= 0 && Maze[Py, Px - 15] == ' ')
        {
            EraseCar();
            Px -= 15;
            PrintCar();
        }
    }

    public void MoveCarUp()
    {
        if (Py - 7 >= 0 && Maze[Py - 7, Px] == ' ')
        {
            EraseCar();
            Py -= 7;  // Move by full car height
            PrintCar();
        }
    }

    public void MoveCarDown()
    {
        if (Py + 7 < 47 && Maze[Py + 7, Px] == ' ')
        {
            EraseCar();
            Py += 7;
            PrintCar();
        }
    }
}


    
    