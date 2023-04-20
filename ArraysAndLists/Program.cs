using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine("----- Evens --------");
            foreach (int j in evens)
            {
                    Console.Write(j);
                    Console.Write(" ");
                    Console.WriteLine();
            }

            Console.WriteLine("----- Odds --------");
            foreach (int j in odds)
            {
                Console.WriteLine(j);
            }
        }
    }
}
