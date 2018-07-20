using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDeckClass
{
    /// <summary>
    /// Classes and Objects lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using a Deck class
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            bool deckEmpty = deck.Empty;

            //deck.Print();
            //deck.Cut(4);
            Console.WriteLine();
            //deck.Shuffle();
            //deck.Print();

            Console.WriteLine();

            Card card = deck.TakeTopCard();

            Console.WriteLine(card.Rank + " of " + card.Suit);
        }
    }
}
