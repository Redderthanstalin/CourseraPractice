using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4)
            {
                
                Console.WriteLine("**********");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game:");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");

                Console.WriteLine("**********");

                Console.Write("What would you like to do: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice <= 0 || choice >= 5)
                {
                    Console.WriteLine("Your answer must be between 1 and 4. Try again.");
                    Console.WriteLine();
                    Console.Write("What would you like to do: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                }

                if (choice == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Starting a new game...");
                    Console.WriteLine();
                }
                else if (choice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Loading game...");
                    Console.WriteLine();
                }
                else if (choice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("You don't get options here!");
                    Console.WriteLine();
                }

            }
        }
    }
}
