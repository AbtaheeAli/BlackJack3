using System;

namespace BlackJack3
{

    class Program
    {
        static void displayGreeting()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("<><><><><> Lets play some Blackjack!<><><><><>   ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
        }

        static void displayDealer()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("            Dealer's turn!  ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            displayGreeting();

            var deck = new Deck();

            deck.MakeCards();

            var playerOneHand = new Hand();
            var dealerHand = new Hand();

            var firstCardForPlayerOne = deck.Deal();
            playerOneHand.Accept(firstCardForPlayerOne);
            var secondCardForPlayerOne = deck.Deal();
            playerOneHand.Accept(secondCardForPlayerOne);

            var dealerFirstCard = deck.Deal();
            dealerHand.Accept(dealerFirstCard);
            var dealerSecondCard = deck.Deal();
            dealerHand.Accept(dealerSecondCard);

            while (playerOneHand.TotalValue() <= 21)
            {

                Console.WriteLine();
                playerOneHand.ShowTheCards();
                Console.WriteLine($"The total value of your hand is {playerOneHand.TotalValue()}");
                Console.WriteLine();

                Console.WriteLine("Would you like to Hit or Stand?");
                Console.WriteLine("\th - Hit");
                Console.WriteLine("\ts - Stand");
                Console.WriteLine("What is your decision?");

                var input = Console.ReadLine();
                if (input == "h")
                {
                    var anotherCard = deck.Deal();
                    playerOneHand.Accept(anotherCard);
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine();
            playerOneHand.ShowTheCards();
            Console.WriteLine($"Your value of your cards is {playerOneHand.TotalValue()}");
            Console.WriteLine();

            while (dealerHand.TotalValue() <= 17)
            {
                var anotherCard = deck.Deal();
                dealerHand.Accept(anotherCard);
            }
            displayDealer();
            Console.WriteLine("It's the Dealers turn! Press any button to display the Dealers hand.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("The Dealer has... ");
            Console.WriteLine();
            dealerHand.ShowTheCards();
            var totalOfDealerHands = dealerHand.TotalValue();
            Console.WriteLine();
            Console.WriteLine($"A total of {totalOfDealerHands}");
            Console.WriteLine();

            if (playerOneHand.TotalValue() > 21)
            {
                Console.WriteLine("You Busted!");
            }

            else if (dealerHand.TotalValue() > 21)
            {
                Console.WriteLine("You WIN!!");
            }
            else if (dealerHand.TotalValue() >= playerOneHand.TotalValue())
            {
                Console.WriteLine("You Busted!");
            }
            else
            {
                Console.WriteLine("You WIN!!");
            }

            Console.WriteLine("Thank you for playing! Would you like to continue? Press any button to make some money!");
            Console.ReadKey();

            Main(null);
        }


    }

}