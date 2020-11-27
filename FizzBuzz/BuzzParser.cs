using System;
using FizzBuzz.Interfaces;

namespace FizzBuzz
{
    public class BuzzParser
    {
        public IKonsole Konsole { get; set; }
        public void Run(int count = 300)
        {
            for (var i = 1; i <= count; i++)
            {
                Konsole.PrintLine(ToFuzzString(i));
            }
        }

        public static string ToFuzzString(int num)
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