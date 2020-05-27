using System;
using System.Collections.Generic;

namespace BlackJack3
{
    class Hand
    {
        public List<Card> CardsHeld = new List<Card>();

        public void Accept(Card cardWeAreHolding)
        {
            CardsHeld.Add(cardWeAreHolding);
        }
        public void ShowTheCards()
        {
            foreach (var card in CardsHeld)
                Console.WriteLine($"{card.Rank} of {card.Suit}");

        }
        public int TotalValue()
        {
            var total = 0;

            foreach (var card in CardsHeld)
            {
                var cardValue = card.Value();
                total += cardValue;
            }

            return total;
        }
    }
}
