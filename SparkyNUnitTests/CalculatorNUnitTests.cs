using NUnit.Framework;

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
        private Calculator calc;
        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }


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



        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            //Arrange
            List<int> expectedOddRange = new List<int>() { 5, 7, 9 }; //5-10


            //Act
            List<int> result = calc.GetOddRange(5, 10);


            //Assert
            Assert.That(result, Is.EquivalentTo(expectedOddRange)); //specialy for collections

            //Check if a collection contains a spesific value
            //Assert.Contains(7,result);
            Assert.That(result, Does.Contain(7));

            //Make shure that the collection does not contain a spesific value
            Assert.That(result, Has.No.Member(6));

            //Check if result is empty
            Assert.That(result, Is.Not.Empty);

            //Counter in collections
            Assert.That(result.Count, Is.EqualTo(3));

            //Check if the order is assending 
            Assert.That(result, Is.Ordered);

            //Check if the order is descending 
            //Assert.That(result, Is.Ordered.Descending);


        }
        #endregion
    }
}
