using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {


            // print welcome message
            Console.WriteLine("Hello and welcome to a game that is almost, but not completely, unlike Blackjack.");
            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card Player1Card1 = deck.TakeTopCard();
            Card Player2Card1 = deck.TakeTopCard();
            Card DealerCard1 = deck.TakeTopCard();
            Card Player1Card2 = deck.TakeTopCard();
            Card Player2Card2 = deck.TakeTopCard();
            Card DealerCard2 = deck.TakeTopCard();
            Console.WriteLine();

            // flip all the cards over
            Player1Card1.FlipOver();
            Player2Card1.FlipOver();
            DealerCard1.FlipOver();
            Player1Card2.FlipOver();
            Player2Card2.FlipOver();
            DealerCard2.FlipOver();
            // print the cards for player 1
            Console.WriteLine("Player 1: " + Player1Card1.Rank + " of " + Player1Card1.Suit + " and a " + Player1Card2.Rank + " of " + Player1Card2.Suit);

            // print the cards for player 2
            Console.WriteLine("Player 2: " + Player2Card1.Rank + " of " + Player2Card1.Suit + " and a " + Player2Card2.Rank + " of " + Player2Card2.Suit);
            // print the cards for player 3
            Console.WriteLine("Player 3: " + DealerCard1.Rank + " of " + Player2Card1.Suit + " and a " + DealerCard2.Rank + " of " + DealerCard2.Suit);
            Console.WriteLine();
        }
    }
}
