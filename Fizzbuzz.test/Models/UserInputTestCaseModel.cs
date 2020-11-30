using System;
using System.Collections.Generic;

namespace Fizzbuzz.test
{
    /// <summary>
    ///     Object that stores strings and inputs to be tested in order.
    /// </summary>
    public class UserInputTestCaseModel
    {
        private int inputKeysIndex;

        private int inputStringsIndex;

        //Each entry is an "console.readline"- response. 
        public List<string> InputStrings { get; set; }

        //Each entry is an "console.readkey" response. 
        public List<ConsoleKey> InputKeys { get; set; }

        /// <summary>
        ///     Presents next fake "console.readline". Repeats last entry if index > count
        /// </summary>
        /// <returns></returns>
        public string NextInputString()
        {
            var current = InputStrings[inputStringsIndex];
            if (inputStringsIndex + 1 < InputStrings.Count) inputStringsIndex++;
            return current;
        }

        /// <summary>
        ///     presents next fake "console.readkey" Repeats last entry if index > count
        /// </summary>
        /// <returns></returns>FizzbuzzTests
        public ConsoleKey NextInputKey()
        {
            var current = InputKeys[inputKeysIndex];
            if (inputKeysIndex + 1 < InputKeys.Count) inputKeysIndex++;
            return current;
        }
    }

    public class TestCases
    {
        public static UserInputTestCaseModel SingleValueTest(string value)
        {
            return new()
            {
                InputKeys = new List<ConsoleKey> {ConsoleKey.Escape, ConsoleKey.Escape, ConsoleKey.Escape},
                InputStrings = new List<string>
                {
                    value, "exit"
                }
            };
        }
    }
}