using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        #region AddNumbersTests
        Calculator calculator = new Calculator();
        [Test]
        public void AddNumbers_InputOfTwoInt_GetCorrectAddition()
        {
            //Arrange
           
            int expected = 30;
            //Act
            int actual = calculator.AddTwoNummbers(10, 20);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(5.4, 10.5)] //15.9
        [TestCase(5.43, 10.53)] //15.96
        [TestCase(5.49, 10.59)] //16.08
        public void AddNumbersDouble_InputTwoDoble_GetCorrectAddition(double a, double b)
        {
            //Arrange


            //Act
            double result = calculator.AddTwoDoubles(a, b);
            //delta is the number of range ex. between 15.9 and 16.9 delta is 1 
            double delta = 1;
            //Assert
            Assert.AreEqual(15.9, result, delta);
        }
        #endregion
        #region OddNumberTests

        [Test]
        public void IsNumberOdd_IntNumber_ReturnFalse()
        {
            //Arange         
            //Act
            bool actual = calculator.IsOddNumber(10);

            //Assert

            Assert.That(actual, Is.EqualTo(false));
 
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsNumberOdd_IntNumber_ReturnTrue(int a)
        {
            //Arange
            //Act
            bool actual = calculator.IsOddNumber(a);

            //Assert
            Assert.That(actual, Is.EqualTo(true));

        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            bool result = calculator.IsOddNumber((int)a);
            return result;
        }
        #endregion
    }
}
