namespace FizzBuzz
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;

    public class FizzBuzzService
    {
        /// <summary>
        /// Returns an infinite sequence of FizzBuzz numbers
        /// </summary>
        public IEnumerable<string> FizzBuzzSequence
        {
            get
            {
                long index = 1;
                while (true)
                {
                    yield return this.Transform(index);
                    index += 1;
                }
            }
        }

        /// <summary>
        /// Transforms a given number to its FizzBuzz representation
        /// </summary>
        /// <param name="number">The numeric value to transform.</param>
        /// <returns>The mapped FizzBuzz number.</returns>
        public string Transform(long number)
        {
            var divisibleBy3 = number % 3 == 0;
            var divisibleBy5 = number % 5 == 0;

            if (divisibleBy3 && divisibleBy5)
                return "FizzBuzz";

            if (divisibleBy3)
                return "Fizz";

            if (divisibleBy5)
                return "Buzz";

            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
