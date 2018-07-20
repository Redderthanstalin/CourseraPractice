using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problem 1
            //Console.Write("What's the number to start at?");
            //int lowNum = Convert.ToInt32(Console.ReadLine());
            //Console.Write("What's the number you want to end at?");
            //int highNum = Convert.ToInt32(Console.ReadLine());

            //for(int i = lowNum; i <= highNum; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            deck.Shuffle();

            for(int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            for(int i = 0; i < hand.Count; i++)
            {
                hand[i].FlipOver();
            }

            foreach(Card card in hand)
            {
                card.Print();
            }
        }
    }
}
