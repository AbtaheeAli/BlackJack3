using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack3
{
    class Deck
    {
        private List<Card> Cards = new List<Card>();

        public void MakeCards()
        {
            var ranks = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            var suits = new List<string>() { "Clubs", "Spades", "Diamonds", "Hearts" };
            for (var rankIndex = 0; rankIndex < ranks.Count(); rankIndex++)
            {
                for (var suitIndex = 0; suitIndex < suits.Count(); suitIndex++)
                {
                    var newCard = new Card();
                    newCard.Rank = ranks[rankIndex];
                    newCard.Suit = suits[suitIndex];
                    Cards.Add(newCard);
                }

            }
            var n = 52;
            // for firstIndex from n - 1 down to 1 do:
            for (var firstIndex = n - 1; firstIndex >= 1; firstIndex--)
            {

                Random rnd = new Random();

                var secondIndex = rnd.Next(firstIndex);

                var firstValue = Cards[firstIndex];

                var secondValue = Cards[secondIndex];
                // swap cards
                Cards[firstIndex] = secondValue;
                Cards[secondIndex] = firstValue;
            }
        }
        public Card Deal()
        {
            var card = Cards[0];

            Cards.Remove(card);

            return card;

        }
    }
}
