using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTest
    {
        [Test]
        public void CombineNames_InputFirstAndLastName_ReturnGreetingsAndFullName()
        {
            //Arrange
            Customer customer = new Customer();

            //Act
            string fullName = customer.GreetAndCombineNames("Petar", "Petrov");

            //Assert
            Assert.That(fullName, Is.EqualTo("Hello, Petar Petrov"));
            //Assert.AreEqual(fullName, "Hello, Petar Petrov");
            Assert.That(fullName, Does.Contain(","));//case sensitive
            Assert.That(fullName, Does.Contain("hello").IgnoreCase);//Not Case sensitive
            Assert.That(fullName, Does.StartWith("Hello"));
            Assert.That(fullName, Does.EndWith("Petrov"));
            Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }
    }
}
