using System;

namespace FizzBuzz.Interfaces
{
    public interface IKonsole
    {
        string ReadLine();
        ConsoleKey GetKey();
        void Print(string val);
        void PrintLine(string val);
        
    }
}