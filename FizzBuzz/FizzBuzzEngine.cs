using System;
using FizzBuzz.Interfaces;

namespace FizzBuzz
{
    /// <summary>
    ///     user interactions and handling for fizzbuzz - console.
    /// </summary>
    public class FizzBuzzEngine
    {
        private readonly FizzBuzzParser _fizzBuzzParser;

        public FizzBuzzEngine(IKonsole konsole)
        {
            Konsole = konsole;
            _fizzBuzzParser = new FizzBuzzParser {Konsole = Konsole};
        }

        public IKonsole Konsole { get; }

        public void Run()
        {
            Konsole.PrintLine("Welcome to UltraBuzz!\n" +
                              "Choose a number between 1-300 to show fizzbuzz\n");
            Konsole.Print("\nPress any key to Start...");

            Konsole.GetKey();

            MainLoop();
        }

        public void MainLoop()
        {
            while (true)
            {
                Console.Clear();
                Konsole.PrintLine("Choose a number between 1-300 to show fizzbuzz count. Type 'exit' to exit.");

                _fizzBuzzParser.Print(HandleUserInput() ?? 0); //0 if user types exit. 

                Konsole.Print("\nPress Esc to exit or any other key to run again.");

                switch (Konsole.GetKey())
                {
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }

        /// <summary>
        ///     Loops until user enters a number or types exit.
        /// </summary>
        /// <returns></returns>
        public int? HandleUserInput()
        {
            while (true)
            {
                Konsole.Print("\nNumber << ");
                var input = Konsole.ReadLine();

                switch (input.ToUpper())
                {
                    case "EXIT":
                        return null;
                }

                if (!int.TryParse(input, out var userInput))
                    Konsole.PrintLine(">> Not a valid number.");
                else
                    switch (userInput)
                    {
                        case < 1:
                            Konsole.PrintLine($">> Number cannot be negative or 0. Min 1; << {userInput}");
                            break;
                        case > 300:
                            Konsole.PrintLine($">> Number was too high. Max 300; << {userInput}");
                            break;
                        default:
                            return userInput;
                    }
            }
        }
    }
}