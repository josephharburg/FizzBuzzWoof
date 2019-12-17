
using FizzBuzzApp;
using NUnit.Framework;

namespace FizzBuzzWoof
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DoesMethodReturnFizzWhenDivisibleByThree()
        {
            Testing testing = new Testing();
            testing.FizzBuzzMethod("31");
            Assert.AreEqual("Fizz", testing.Fizz);
           
        }
        [Test]
        public void DoesMethodReturnBuzzWhenDivisibleByFive()
        {
            Testing testing = new Testing();
            testing.FizzBuzzMethod("51");
            Assert.AreEqual("Buzz", testing.Buzz);

        }
        [Test]
        public void DoesMethodReturnWoofWhenDivisibleBySeven()
        {
            Testing testing = new Testing();
            testing.FizzBuzzMethod("71");
            Assert.AreEqual("Woof", testing.Woof);

        }
        [Test]
        public void DoesMethodReturnFizzBuzzWoofWhenMatchesMultipleRules() 
        {
            Testing test = new Testing();
            test.FizzBuzzMethod("2");
            Assert.AreEqual("FizzBuzz", test.FizzBuzz);
            test.FizzBuzzMethod("15");
            Assert.AreEqual("FizzBuzzWoof", test.FizzBuzzWoof);

        }

    }
}