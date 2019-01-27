using NUnit.Framework;
using FizzBuzz.Code;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class DemoTests
    {
        [Test]
        public void FizzBuzzLuckyWorksWithTallyUpToTwenty()
        {
            var fizzBuzzDemo = new Demo();
            var expected = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz fizz: 4 buzz: 3 fizzbuzz: 1 lucky: 2 integer: 10";
            var actual = fizzBuzzDemo.Print(1, 20);
            Assert.AreEqual(expected, actual);
        }
    }
}