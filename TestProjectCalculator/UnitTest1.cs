using net_calculator_tester;
using System.Security.Cryptography.X509Certificates;

namespace TestProjectCalculator
{
    public class Tests
    {
        public float num;
        [SetUp]
        public void Setup()
        {
        }

        
        [TestCase(0, 0, 0)]
        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(2, -2, 0)]
        [TestCase(10, 2, 12)]
        public void TestAdd(float numberA, float numberB, float expectedResult)
        {
            Assert.That(Calculator.Add(numberA, numberB), Is.EqualTo(expectedResult), $"Addition has unexpected result: {numberA} + {numberB} ");
        }

        [TestCase(0, 0, 0)]
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 0)]
        [TestCase(2, -2, 4)]
        [TestCase(10, 2, 8)]
        public void TestSubstract(float numberA, float numberB, float expectedResult)
        {
            Assert.That(Calculator.Substract(numberA, numberB), Is.EqualTo(expectedResult), $"Addition has unexpected result: {numberA} + {numberB} ");
        }

        [TestCase(0, 0, 0)]
        [TestCase(1, 2, 0.5f)]
        [TestCase(2, 2, 1)]
        [TestCase(2, -2, -1)]
        [TestCase(10, 2, 5)]
        public void TestDivide(float numberA, float numberB, float expectedResult)
        {
            Assume.That(numberB != 0.0);
            Assert.That(Calculator.Divide(numberA, numberB), Is.EqualTo(expectedResult), $"Addition has unexpected result: {numberA} + {numberB} ");
        }

        [TestCase(0, 0, 0f)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(2, -2, -4f)]
        [TestCase(10, 2, 20)]
        public void TestMultiply(float numberA, float numberB, float expectedResult)
        {
            Assert.That(Calculator.Multiply(numberA, numberB), Is.EqualTo(expectedResult), $"Addition has unexpected result: {numberA} + {numberB} ");
        }
    }
}