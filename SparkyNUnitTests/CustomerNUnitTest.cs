using NUnit.Framework;
using System;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTest
    {
        private Customer customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }


        [Test]
        public void CombineNames_InputFirstAndLastName_ReturnGreetingsAndFullName()
        {
            //Arrange
           

            //Act
            string fullName = customer.GreetAndCombineNames("Petar", "Petrov");
           //Asserting multiple does not stop after the first failed test
            Assert.Multiple(() =>
            {
                Assert.That(fullName, Is.EqualTo("Hello, Petar Petrov"));
                //Assert.AreEqual(fullName, "Hello, Petar Petrov");
                Assert.That(fullName, Does.Contain(","));//case sensitive
                Assert.That(fullName, Does.Contain("hello").IgnoreCase);//Not Case sensitive
                Assert.That(fullName, Does.StartWith("Hello"));
                Assert.That(fullName, Does.EndWith("Petrov"));
                Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
            });
            //Assert
           
        }


        [Test]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            //Arrange
            
            //Act


            //Assert
            Assert.IsNull(customer.GreetMessage);

        }

        [Test]
        public void DiscountCheck_DefaultCustomer_ReturnDiscountInRange()
        {
            int result = customer.Discount;
            //check if the discount is in range of 10-25
            Assert.That(result, Is.InRange(10,25));
            
        }


        [Test]
        public void GreetMessage_GreeteWithoutLastName_ReturnsNotNull()
        {
            customer.GreetAndCombineNames("petar", "");


            Assert.IsNotNull(customer.GreetMessage);


            Assert.IsFalse(string.IsNullOrEmpty(customer.GreetMessage));
        }

        [Test]
        public void GreetChecker_EmptyFirstNAme_ThrowsException()
        {

            var exception = Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Petrov"));
           

            Assert.That("Empty first name", Is.EqualTo("Empty first name"));
        }
    }
}
