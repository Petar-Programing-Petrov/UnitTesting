using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyMSTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void AddNumbers_InputOfTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int expected = 30; 
            //Act
            int actual = calculator.AddTwoNummbers(10, 20);

            //Assert
            Assert.AreEqual(expected, actual);


        }
    }
}
