using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                integers.Add(i + 1);
            }

            for(int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }

            Console.WriteLine();

            for(int i = 9; i >= 0; i--)
            {
                if (integers[i] % 2 == 0)
                {
                    integers.Remove(integers[i]);
                }
            }
            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }

            Console.WriteLine();

            List<int> smallList = new List<int>();

            for(int i = 0; i < 5; i++)
            {
                smallList.Add(i + 1);
            }
            for (int i = 0; i < smallList.Count; i++)
            {
                Console.WriteLine(smallList[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                smallList.Remove(smallList[0]);
            }
            for(int i = 0; i < smallList.Count; i++)
            {
                Console.WriteLine(smallList[i]);
            }
        }
    }
}
