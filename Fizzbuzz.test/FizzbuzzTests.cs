using FizzBuzz;
using Fizzbuzz.test.Outputters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fizzbuzz.test
{
    [TestClass]
    public class FizzbuzzTests
    {
        private static readonly TestKonsole Konsole = new();

        private readonly FizzBuzzEngine Engine = new(Konsole);

        // array of expected words from values. 
        private readonly FizzBuzzTestModel[] testModels =
        {
            new() {Word = "1", Value = 1},
            new() {Word = "Fizz", Value = 3},
            new() {Word = "Buzz", Value = 5},
            new() {Word = "Fizzbuzz", Value = 15},
            new() {Word = "Answer to the Ultimate Question of Life, the Universe, and Everything", Value = 42}
        };

        [TestMethod]
        public void TestFizzParse()
        {
            foreach (var entry in testModels) Assert.AreEqual(entry.Word, FizzBuzzParser.GetFizzBuzzValue(entry.Value));
        }

        [TestMethod]
        public void TestHadleUserInput_Valid()
        {
            Konsole.TestCase = TestCases.SingleValueTest("123");
            var success = Engine.HandleUserInput();

            Assert.AreEqual(123, success);

            Konsole.TestCase = TestCases.SingleValueTest("1");
            success = Engine.HandleUserInput();

            Assert.AreEqual(1, success);

            Konsole.TestCase = TestCases.SingleValueTest("300");
            success = Engine.HandleUserInput();

            Assert.AreEqual(300, success);
        }

        [TestMethod]
        public void TestHadleUserInput_Invalid()
        {
            // Too low
            Konsole.TestCase = TestCases.SingleValueTest("-1");
            Engine.HandleUserInput();

            Assert.AreEqual(">> Number cannot be negative or 0. Min 1; << -1",
                Konsole.PrintedLines[Konsole.PrintedLines.Count - 1]);

            // Too high
            Konsole.TestCase = TestCases.SingleValueTest("301");
            Engine.HandleUserInput();

            Assert.AreEqual(">> Number was too high. Max 300; << 301",
                Konsole.PrintedLines[Konsole.PrintedLines.Count - 1]);

            // Non-numeric
            Konsole.TestCase = TestCases.SingleValueTest("AAAAAAAaaaaaaaadadddddddddddssssssssssssssssssssssdad");
            Engine.HandleUserInput();

            Assert.AreEqual(">> Not a valid number.", Konsole.PrintedLines[Konsole.PrintedLines.Count - 1]);
        }
    }
}