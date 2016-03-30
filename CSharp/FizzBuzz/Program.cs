namespace FizzBuzz
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzService();

            var sequence = fizzBuzz.FizzBuzzSequence.Take(20).ToList();

            sequence.ForEach(fbNum => Console.WriteLine(fbNum));

            Console.WriteLine();
            Console.WriteLine("Press return to exit.");
            Console.ReadLine();
        }
    }
}
