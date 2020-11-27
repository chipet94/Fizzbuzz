using System;
using FizzBuzz.Outputters;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        { 
            var fizz = new FizzBuzzEngine(new Konsole());
            fizz.Run();
        }
    }
}