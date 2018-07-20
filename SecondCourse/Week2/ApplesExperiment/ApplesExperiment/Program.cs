using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(true, 100);
            Console.WriteLine(apple.Organic);
            Console.WriteLine(apple.AmountLeft);

            apple.TakeBite(10);
            Console.WriteLine(apple.AmountLeft);

        }
    }
}
