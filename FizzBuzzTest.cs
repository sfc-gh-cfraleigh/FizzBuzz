using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz4
{
    class FizzBuzzTest
    {
        [Test]
        public void returnZeroWhenPazzingZeroTest()
        {
            var zeroTest = new FizzBuzz();

            var testValue = zeroTest.doFizzBuzz(0);

            Assert.That(testValue, Is.EqualTo("0"));


        }
        [Test]
        public void confirmMultipleofThreeReturnsFizzTest()
        {
            var fizzTest = new FizzBuzz();

            var testValue = fizzTest.doFizzBuzz(6);

            Assert.That(testValue, Is.EqualTo("Fizz"));
        }
        [Test]
        public void confirmMultipleOfFiveReturnsBuzzTest()
        {
            var fizzTest = new FizzBuzz();

            var testValue = fizzTest.doFizzBuzz(5);

            Assert.That(testValue, Is.EqualTo("Buzz"));
        }
        [Test]
        public void confirmLoopRetunsFizzBuzzStringTest()
        {
            var fizzTest = new FizzBuzz();

            var testValue = fizzTest.doFizzBuzz(15);

            Assert.That(testValue, Is.EqualTo("012Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz"));
        }
    }
}
