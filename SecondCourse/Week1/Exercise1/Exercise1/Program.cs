using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            List<Card> cards = new List<Card>();

            deck.Shuffle();
            cards.Add(deck.TakeTopCard());
            cards[0].FlipOver();
            cards[0].Print();
            cards.Add(deck.TakeTopCard());
            cards[1].FlipOver();
            cards[1].Print();

            Console.WriteLine();
        }
    }
}
