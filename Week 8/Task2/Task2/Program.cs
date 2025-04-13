using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DeckGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;
            int score = 0;
            Deck obj = new Deck();

            obj.Shuffle();

            Card card1 = obj.DealCard(); 

            int option = 0;

            while (gameRunning)
            {
                int remain_check = obj.CardsLeft();
                Card card2 = obj.DealCard();
                Console.WriteLine("*");
                Console.WriteLine(card1.GetCardAsString());
                Console.WriteLine("");
                Console.WriteLine("*** Remaining cards *** : " + remain_check);
                Console.WriteLine("Enter 1 if the next card is higher.");
                Console.WriteLine("Enter 2 if the next card is lower.");

                int card_check = int.Parse(Console.ReadLine());
                Console.Clear();

                if (card_check == 1)
                {
                    if (card2.GetValue() >= card1.GetValue())
                    {
                        score++;
                        card1 = card2;
                    }
                    else
                    {
                        gameRunning = false;
                        Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
                        Console.WriteLine("The Card was " + card2.GetCardAsString());
                        Console.WriteLine("You Score is : " + score);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                if (card_check == 2)
                {
                    if (card2.GetValue() < card1.GetValue()) 
                    {
                        score++;
                        card1 = card2;
                    }
                    else
                    {
                        gameRunning = false;
                        Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
                        Console.WriteLine("The Card was " + card2.GetCardAsString());
                        Console.WriteLine("You Score is : " + score);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                if (obj.CardsLeft() == 0 && card2 == null)
                {
                    gameRunning = false;
                    Console.WriteLine("Congrats you have scored maximum.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }

            while (option != 2) { }
        }

        public static void GuessGameHeader()
        {
            Console.Clear();
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("| Guess The Next Card Game |");
            Console.WriteLine("+--------------------------+");
        }
        public static void BlackJackGameHeader()
        {
            Console.Clear();
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| Black Jack Card Game |");
            Console.WriteLine("+----------------------+");
        }
        public static void menu()
        {
            Console.WriteLine("Press 1 To Play Guess The Next Card Game");
            Console.WriteLine("Press 2 To Play The Black Jack Game");
            Console.WriteLine("Press x To Exit");
        }
        public static string Gamemenu()
        {
            Console.WriteLine("Press 1 To Start");
            Console.WriteLine("Press x To Exit");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}