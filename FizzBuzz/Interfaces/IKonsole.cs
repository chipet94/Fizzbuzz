using System;

namespace FizzBuzz.Interfaces
{
    /// <summary>
    /// Interface for different application input and output handling.
    /// Mainly to make input & output - testing easier...
    /// </summary>
    public interface IKonsole
    {
        string ReadLine();
        ConsoleKey GetKey();
        void Print(string val);
        void PrintLine(string val);
        
    }
}