using System;
using System.Collections.Generic;
using FizzBuzz.Outputters;

namespace Fizzbuzz.test.Outputters
{
    /// <summary>
    ///     Fake-Console for testing. Stores fake user-interactions as testcase.
    /// </summary>
    public class TestKonsole : Konsole
    {
        public TestKonsole()
        {
            PrintedLines = new List<string>();
            Printed = new List<string>();
        }

        //All posted Konsole.printlines.
        public List<string> PrintedLines { get; set; }

        //All posted Konsole.prints
        public List<string> Printed { get; set; }

        public UserInputTestCaseModel TestCase { get; set; }

        public override void PrintLine(string val)
        {
            PrintedLines.Add(val);
        }

        public override void Print(string val)
        {
            Printed.Add(val);
        }

        //Gets next key from testcase
        public override ConsoleKey GetKey()
        {
            return TestCase.NextInputKey();
        }

        // gets next string from testcase. 
        public override string ReadLine()
        {
            return TestCase.NextInputString();
        }
    }
}