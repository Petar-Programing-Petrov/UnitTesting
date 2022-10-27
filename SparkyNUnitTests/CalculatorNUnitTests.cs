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
        public void CheckNumber_IntNumber_GetOddNumber()
        {
            //Arange
            
            //Act
            bool actual = calculator.IsOddNumber(1);

            //Assert
            Assert.IsTrue(actual);
        }

    }
}
