using System;
using FizzBuzz.Interfaces;

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        private readonly BuzzParser fizzbuzzer;
        private readonly IKonsole _konsole;

        public IKonsole Konsole => _konsole;

        public FizzBuzzEngine(IKonsole konsole)
        {
            _konsole = konsole;
            fizzbuzzer = new BuzzParser {Konsole = _konsole};
            Start();
        }

        public void Start()
        {
            Konsole.PrintLine("Welcome to UltraBuzz!\n" +
                              "Choose a number between 1-300 to show fizzbuzz\n");
            Konsole.Print("\nPress any key to continue...");
            
            Konsole.GetKey();

            MainLoop();
        }

        public void MainLoop()
        {
            while (true)
            {
                Console.Clear();
                Konsole.PrintLine("Choose a number between 1-300 to show fizzbuzz count.");
                
                fizzbuzzer.Run(HandleUserInput());

                Konsole.Print("\nPress Esc to exit or any other key to run again.");

                switch (Konsole.GetKey())
                {
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }

        public int HandleUserInput()
        {
            while (true)
            {
                Konsole.Print("\nNumber << ");
                var input = Konsole.ReadLine();

                switch (input.ToUpper())
                {
                    case "EXIT":
                        Environment.Exit(0);
                        break;
                }

                if (!int.TryParse(input, out var num))
                {
                    Konsole.PrintLine(">> Not a valid number.");
                }
                else
                    switch (num)
                    {
                        case < 1:
                            Konsole.PrintLine($">> Number cannot be negative or 0. Min 1; << {num}");
                            break;
                        case > 300:
                            Konsole.PrintLine($">> Number was too high. Max 300; << {num}");
                            break;
                        default:
                            return num;
                    }
            }
        }
    }
}