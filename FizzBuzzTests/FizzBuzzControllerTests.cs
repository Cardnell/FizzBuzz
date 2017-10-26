using FizzBuzz.Controllers;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzControllerTests
    {
        [SetUp]
        public void SetupTests()
        {
        }

        [TestCase(2)]
        [TestCase(17)]
        [TestCase(26)]
        public void FizzBuzz_IntegersNotDivisibleByFiveOrThree_ReturnsInput(int input)
        {
            var fizzBuzz = new FizzBuzzController();

            string output = fizzBuzz.Get(input);

            Assert.That(output, Is.EqualTo(input.ToString()));
        }

        [TestCase(6)]
        [TestCase(9)]
        [TestCase(21)]
        public void FizzBuzz_TakesMutiplesOfThree_ReturnsFizz(int input)
        {
            var fizzBuzz = new FizzBuzzController();

            string output = fizzBuzz.Get(input);

            Assert.That(output, Is.EqualTo("Fizz"));
        }

        [TestCase(10)]
        [TestCase(25)]
        [TestCase(35)]
        public void FizzBuzz_TakesMutiplesOfFive_ReturnsBuzz(int input)
        {
            var fizzBuzz = new FizzBuzzController();

            string output = fizzBuzz.Get(input);

            Assert.That(output, Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(45)]
        [TestCase(60)]
        public void FizzBuzz_TakesMultiplesOfThreeAndFive_ReturnsFizzBuzz(int input)
        {
            var fizzBuzz = new FizzBuzzController();

            string output = fizzBuzz.Get(input);

            Assert.That(output, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void FizzBuzz_TakesFive_ReturnsBuzz()
        {
            var fizzBuzz = new FizzBuzzController();

            string output = fizzBuzz.Get(5);

            Assert.That(output, Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzz_TakesThree_ReturnsFizz()
        {
            var fizzBuzz = new FizzBuzzController();

            string output = fizzBuzz.Get(3);

            Assert.That(output, Is.EqualTo("Fizz"));
        }

        // At this point I've tested the functionality, but not the JSON output 
        //on an actual api call.  This should certainly be tested in an automated fashion, 
        //but given the framework, I left a speficic xml request to still return xml
        //which complicated the test somewhat, and given the parameters of the instructions
        //I was not able to complete it in the specific time.
    }
}