using System;
using System.Collections.Generic;

namespace FizzBuzz.Outputters
{
    public class SKonsole : Konsole
    {
        public List<string> PrintedLines = new();
        public List<string> Printed = new();
        public string InputString { get; set; }
        public ConsoleKey InputKey { get; set; }
        public override void PrintLine(string val)
        {
            PrintedLines.Add(val);
        }

        public override void Print(string val)
        {
            Printed.Add(val);
        }

        public override ConsoleKey GetKey()
        {
            return InputKey;
        }
        public override string ReadLine()
        {
            return InputString;
        }
    }
}