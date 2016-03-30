namespace FizzBuzzTests
{
    using System.Collections.Generic;
    using System.Linq;
    using FizzBuzz;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        private FizzBuzzService fizzBuzz;

        [TestFixtureSetUp]
        public void Setup()
        {
            this.fizzBuzz = new FizzBuzzService();
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void TestBuzz(long number)
        {
            Assert.That(this.fizzBuzz.Transform(number), Is.EqualTo("Buzz"));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(12)]
        public void TestFizz(long number)
        {
            Assert.That(this.fizzBuzz.Transform(number), Is.EqualTo("Fizz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        public void TestFizzBuzz(long number)
        {
            Assert.That(this.fizzBuzz.Transform(number), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void TestFizzBuzzSequence()
        {
            var sequence = this.fizzBuzz.FizzBuzzSequence;
            var top15 = sequence.Take(15);

            var expected = new List<string>
            {
                "1", "2", "Fizz",
                "4", "Buzz", "Fizz",
                "7", "8", "Fizz",
                "Buzz", "11", "Fizz",
                "13", "14", "FizzBuzz"
            };

            Assert.That(top15, Is.EquivalentTo(expected));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(121, "121")]
        public void TestNumbers(long number, string expected)
        {
            Assert.That(this.fizzBuzz.Transform(number), Is.EqualTo(expected));
        }
    }
}