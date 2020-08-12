using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {

            // Making Cards

            var deck = new List<string>();
            for (var indexCount = 0; indexCount < 4; indexCount++)
            {
                var suit = new List<string> { "Diamonds", "Spades", "Hearts", "Clubs" };
                deck.Add($"Ace of {suit[indexCount]}");
                for (var counter = 2; counter < 11; counter++)
                {
                    deck.Add($"{counter} of {suit[indexCount]}");
                }
                deck.Add($"Jack of {suit[indexCount]}");
                deck.Add($"Queen of {suit[indexCount]}");
                deck.Add($"King of {suit[indexCount]}");
            }
            Console.WriteLine("Deck has been created");
            System.Threading.Thread.Sleep(1000);

            // Shuffle The Deck

            for (int shuffleCount = deck.Count; shuffleCount > 1; shuffleCount--)
            {
                var randomNumberGenerator = new Random();
                var randomNumber = randomNumberGenerator.Next(51);
                var swapContainer = deck[shuffleCount - 1];
                deck[shuffleCount - 1] = deck[randomNumber];
                deck[randomNumber] = swapContainer;
            }
            Console.WriteLine("Deck has been shuffled");
            System.Threading.Thread.Sleep(1000);

            // Show Top 2 Cards

            Console.WriteLine($"First Card: {deck[0]}");
            Console.WriteLine($"Second Card: {deck[1]}");
        }
    }
}