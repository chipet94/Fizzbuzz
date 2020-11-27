using System;
using FizzBuzz.Outputters;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        { 
            new FizzBuzzEngine(new Konsole());
        }
    }
}