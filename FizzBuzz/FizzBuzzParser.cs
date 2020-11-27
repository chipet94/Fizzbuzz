using System;
using FizzBuzz.Interfaces;

namespace FizzBuzz
{
    /// <summary>
    /// Class for translating and printing fizzbuzz values. 
    /// </summary>
    public class FizzBuzzParser
    {
        public IKonsole Konsole { get; set; }

        /// <summary>
        /// Prints all fizzbuzz values between 1 and 300; 
        /// </summary>
        /// <param name="count">How many "laps" that should be printed.</param>
        public void Print(int count = 300)
        {
            if (count <= 0) return;

            for (var i = 1; i <= count; i++)
            {
                Konsole.PrintLine(GetFizzBuzzValue(i));
            }
        }

        /// <summary>
        /// Gets the fizzbuzz-value from a number. 
        /// </summary>
        /// <param name="num">number to be checked.</param>
        public static string GetFizzBuzzValue(int num)
        {
            return num == 42 //om
                ? "Answer to the Ultimate Question of Life, the Universe, andEverything" //ok
                : num % 15 == 0 //annars
                    ? "Fizzbuzz"
                    : num % 3 == 0
                        ? "Fizz"
                        : num % 5 == 0
                            ? "Buzz"
                            : num.ToString();
        }
    }
}