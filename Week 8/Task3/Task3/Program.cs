using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DeckGame;

namespace DeckGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            BlackjackHand playerHand = new BlackjackHand();
            BlackjackHand dealerHand = new BlackjackHand();
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            Console.WriteLine("=== Dealer's Hand ===");
            Console.WriteLine(" [Hidden]");
            Console.WriteLine($" {dealerHand.GetCardAt(1)}\n");
            Console.WriteLine("=== Your Hand ===");
            playerHand.ShowHand();
            Console.WriteLine($"Total: {playerHand.GetBlackjackValue()}\n");
            bool playerBusted = false;
            while (true)
            {
                Console.Write("Do you want to Hit or Stand? (h/s): ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "h")
                {
                    playerHand.AddCard(deck.DealCard());
                    Console.WriteLine("\nYou drew:");
                    playerHand.ShowHand();
                    int total = playerHand.GetBlackjackValue();
                    Console.WriteLine($"Total: {total}\n");
                    if (total > 21)
                    {
                        Console.WriteLine("You busted! Dealer wins.");
                        playerBusted = true;
                        break;
                    }
                }
                else if (choice == "s")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please type 'h' or 's'.");
                }
            }
            if (!playerBusted)
            {
                Console.WriteLine("\n=== Dealer's Turn ===");
                dealerHand.ShowHand();
                Console.WriteLine($"Total: {dealerHand.GetBlackjackValue()}\n");

                while (dealerHand.GetBlackjackValue() < 17)
                {
                    Console.WriteLine("Dealer hits.");
                    dealerHand.AddCard(deck.DealCard());
                    dealerHand.ShowHand();
                    Console.WriteLine($"Total: {dealerHand.GetBlackjackValue()}\n");
                }
                int dealerTotal = dealerHand.GetBlackjackValue();
                int playerTotal = playerHand.GetBlackjackValue();
                if (dealerTotal > 21)
                {
                    Console.WriteLine("Dealer busted! You win!");
                }
                else
                {
                    Console.WriteLine("=== Final Results ===");
                    Console.WriteLine($"Your Total: {playerTotal}");
                    Console.WriteLine($"Dealer's Total: {dealerTotal}");

                    if (playerTotal > dealerTotal)
                        Console.WriteLine("You win!");
                    else if (playerTotal < dealerTotal)
                        Console.WriteLine("Dealer wins!");
                    else
                        Console.WriteLine("It's a tie!");
                }
            }
            Console.WriteLine("\nThanks for playing!");
        }
    }
}
