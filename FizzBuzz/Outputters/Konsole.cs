using System;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Outputters
{
    public class Konsole : IKonsole
    {
        public virtual string ReadLine()
        {
            return Console.ReadLine();
        }

        public virtual ConsoleKey GetKey()
        {
            return Console.ReadKey().Key;
        }

        public virtual void Print(string val)
        {
            Console.Write(val);
        }

        public virtual void PrintLine(string val)
        {
            Console.WriteLine(val);
        }
    }
}