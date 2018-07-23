using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("<pyramid slot number>,<block letter>,<whether or not the block should be lit>");
            string wholeString = Console.ReadLine();
            int firstComma = wholeString.IndexOf(',');

            int secondComma = wholeString.IndexOf(',', firstComma + 1);
            int pyramidSlotNumber = int.Parse(wholeString.Substring(0, firstComma));
            char BlockLetter = wholeString[firstComma + 1];
            bool beLit = bool.Parse(wholeString.Substring(secondComma + 1));

            Console.WriteLine(pyramidSlotNumber);
            Console.WriteLine(BlockLetter);
            Console.WriteLine(beLit);
        }
    }
}
