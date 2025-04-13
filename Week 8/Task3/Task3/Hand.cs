using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeckGame
{
    internal class Hand
    {
        private List<Card> cards;
        public Hand()
        {
            cards = new List<Card>();
        }
        public void AddCard(Card card)
        {
            if (card != null) cards.Add(card);
        }
        public void RemoveCard(Card card)
        {
            if (cards.Contains(card)) cards.Remove(card);
        }
        public void RemoveCard(int index)
        {
            if (index >= 0 && index < cards.Count) cards.RemoveAt(index);
        }
        public int GetCardCount()
        {
            return cards.Count;
        }
        public void ShowHand()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public Card GetCardAt(int index)
        {
            if (index >= 0 && index < cards.Count)
                return cards[index];
            return null;
        }

    }
}