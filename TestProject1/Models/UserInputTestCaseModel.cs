using System;
using System.Collections.Generic;

namespace TestProject1
{
    /// <summary>
    /// Object that stores strings and inputs to be tested in order. 
    /// </summary>
    public class UserInputTestCaseModel
    {
        //Each entry is an "console.readline"- response. 
        public List<string> InputStrings { get; set; }
        
        //Each entry is an "console.readkey" response. 
        public List<ConsoleKey> InputKeys { get; set; }
        
        
        private int inputKeysIndex = 0;
        private int inputStringsIndex = 0;
        
        /// <summary>
        /// Presents next fake "console.readline". Repeats last entry if index > count
        /// </summary>
        /// <returns></returns>
        public string NextInputString()
        {
            var current = InputStrings[inputStringsIndex];
            if (inputStringsIndex + 1 < InputStrings.Count)
            {
                inputStringsIndex++;
            }
            return current;
        }
        /// <summary>
        /// presents next fake "console.readkey" Repeats last entry if index > count
        /// </summary>
        /// <returns></returns>
        public ConsoleKey NextInputKey()
        {
            var current = InputKeys[inputKeysIndex];
            if (inputKeysIndex + 1 < InputKeys.Count)
            {
                inputKeysIndex++;
            }
            return current;
        }


    }

    public class TestCases
    {
        public static UserInputTestCaseModel SingleValueTest(string value)
        {
            return new UserInputTestCaseModel
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