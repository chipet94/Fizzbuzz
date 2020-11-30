using FizzBuzz.Outputters;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fizz = new FizzBuzzEngine(new Konsole());
            fizz.Run();
        }
    }
}