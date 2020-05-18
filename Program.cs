using System;
using System.Collections.Generic;

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
