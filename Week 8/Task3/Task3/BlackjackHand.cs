using System;

namespace DeckGame
{
    internal class BlackjackHand : Hand
    {
        public int GetBlackjackValue()
        {
            int val = 0;
            int aceCount = 0;
            for (int i = 0; i < GetCardCount(); i++)
            {
                Card card = GetCardAt(i);
                int cardValue = card.GetValue();

                if (cardValue > 10)
                    val += 10;
                else if (cardValue == 1)
                {
                    aceCount++;
                    val += 11;
                }
                else
                    val += cardValue;
                }
            while (val > 21 && aceCount > 0)
            {
                val -= 10;
                aceCount--;
            }

            return val;
        }
    }
}
