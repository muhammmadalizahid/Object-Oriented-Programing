using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DeckGame
{
    internal class Card
    {
        private int value;
        private int suit;
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public int GetValue()
        {
            return value;
        }
        public int GetSuit()
        {
            return suit;
        }
        public string GetValueAsString()
        {
            switch (value)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return value.ToString();
            }
        }
        public string GetSuitAsString()
        {
            switch (suit)
            {
                case 0:
                    return "Hearts";
                case 1:
                    return "Diamonds";
                case 2:
                    return "Clubs";
                case 3:
                    return "Spades";
                default:
                    return "Unknown Suit";
            }
        }
        public string GetCardAsString()
        {
            return $"{GetValueAsString()} of {GetSuitAsString()}";
        }
        public override string ToString()
        {
            return GetCardAsString();
        }
    }
}