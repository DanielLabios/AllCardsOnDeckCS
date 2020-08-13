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

            // |Adventure| distribute all cards to 2 players with first 2 cards going to playerHand1

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("distributing cards amongst 2 playerHands");
            var playerHand1 = new List<string>();
            var playerHand2 = new List<string>();
            int distributeCount = 0;
            foreach (string card in deck)
            {
                if (distributeCount < 2)
                {
                    playerHand1.Add(deck[distributeCount]);
                    distributeCount++;
                }
                else
                {
                    if (playerHand1.Count == playerHand2.Count)
                    {
                        playerHand1.Add(deck[distributeCount]);
                    }
                    else
                    {
                        playerHand2.Add(deck[distributeCount]);
                    }
                    distributeCount++;
                }
            }
            // showing both players hand to user for verification of working code

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Playerhand1");
            Console.WriteLine($"Number of cards in hand: {playerHand1.Count}");
            Console.WriteLine("Cards in hand:");
            int cardCount = 0;
            foreach (string card in playerHand1)
            {
                Console.WriteLine(playerHand1[cardCount]);
                cardCount++;
            }
            Console.WriteLine("Playerhand2");
            Console.WriteLine($"Number of cards in hand: {playerHand2.Count}");
            Console.WriteLine("Cards in hand:");
            cardCount = 0;
            foreach (string card in playerHand2)
            {
                Console.WriteLine(playerHand2[cardCount]);
                cardCount++;
            }
            Console.WriteLine("Complete! Here are their hands!");






        }
    }
}