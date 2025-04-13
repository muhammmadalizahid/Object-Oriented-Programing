using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DeckGame
{
    internal class Deck
    {
        private List<Card> cards;
        private int count;
        public Deck()
        {
            cards = new List<Card>();
            for (int suit =0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, suit));
                }
            }
            count = 52;
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int j = rand.Next(i + 1);
                (cards[i], cards[j]) = (cards[j], cards[i]);
            }
        }
        public int CardsLeft()
        {
            return count;
        }
        public Card DealCard()
        {
            if (cards.Count > 0)
            {
                Card dealtCard = cards[0]; 
                cards.RemoveAt(0);
                count--;
                return dealtCard;
            }
            else return null;
        }

    }
}