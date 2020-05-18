using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack3
{
    class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
        public int Value()
        {
            //Takes the string of rank and turns it into an int
            if (Rank == "Ace")
            {
                return 11;
            }
            if (Rank == "King")
            {
                return 10;
            }
            if (Rank == "Queen")
            {
                return 10;
            }
            if (Rank == "Jack")
            {
                return 10;
            }
            if (Rank == "Ten")
            {
                return 10;
            }
            if (Rank == "Nine")
            {
                return 9;
            }
            if (Rank == "Eight")
            {
                return 8;
            }
            if (Rank == "Seven")
            {
                return 7;
            }
            if (Rank == "Six")
            {
                return 6;
            }
            if (Rank == "Five")
            {
                return 5;
            }
            if (Rank == "Four")
            {
                return 4;
            }
            if (Rank == "Three")
            {
                return 3;
            }
            if (Rank == "Two")
            {
                return 2;
            }
            return 0;
        }
    }
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

    }
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();

        }
    }
}
