using System.Collections.Generic;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public partial class UnitTest1
    {
        private FizzBuzzTestModel[] testModels = {
            new() {Word = "1", Value = 1},
            new() {Word = "Fizz", Value = 3},
            new() {Word = "Buzz", Value = 5},
            new() {Word = "Fizzbuzz", Value = 15},
            new() {Word = "Answer to the Ultimate Question of Life, the Universe, andEverything", Value = 42},
        };
        
        [TestMethod]
        public void TestFizzParse()
        {
            foreach (var entry in testModels)
            {
                Assert.AreEqual(entry.Word, BuzzParser.ToFuzzString(entry.Value));
            }
        }

        public void TestHadleUserInput()
        {
            
        }
    }
}