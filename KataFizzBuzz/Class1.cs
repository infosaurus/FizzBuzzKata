using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataFizzBuzz
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FizzBuzzCountsToOneHundred()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual(100, fizzBuzz.Generate().Count);
        }

        [Test]
        public void FirstIsOne()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("1", fizzBuzz.Generate()[0]);
        }

        [Test]
        public void SecondIsTwo()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("2", fizzBuzz.Generate()[1]);
        }

        [Test]
        public void ThirdIsFizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("fizz", fizzBuzz.Generate()[2]);
        }

        [Test]
        public void FifthIsBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("buzz", fizzBuzz.Generate()[4]);
        }

        [Test]
        public void SixthIsFizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("fizz", fizzBuzz.Generate()[5]);
        }

        [Test]
        public void TenthIsBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("buzz", fizzBuzz.Generate()[9]);
        }

        [Test]
        public void FifteenthIsFizzBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("fizzbuzz", fizzBuzz.Generate()[14]);
        }
    }

    public class FizzBuzz
    {
        public IList<string> Generate()
        {
            var list = new List<string>();
            for (int i = 1; i<=100; i++)
            {
                list.Add(FizzBuzzify(i));
            }
            return list;
        }

        private string FizzBuzzify(int i)
        {
            var result = i.ToString();

            if (i % 3 == 0) result = "fizz";
            if (i % 5 == 0) result = result == "fizz" ? "fizzbuzz" : "buzz";

            return result;
        }
    }
}
