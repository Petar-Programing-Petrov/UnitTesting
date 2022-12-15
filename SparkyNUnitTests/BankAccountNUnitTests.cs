using Moq;
using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount account;
        [SetUp]
        public void SetUp()
        {
            
        }
        [Test]
        public void BankDeposit_Add100_ReturnTrue()
        {

            var logMock = new Mock<ILogBook>();
            logMock.Setup(x => x.Log(""));
            BankAccount bankAccount = new(logMock.Object);
            var result = bankAccount.Deposit(100);
            Assert.IsTrue(result);

            Assert.That(bankAccount.Balance, Is.EqualTo(100));


        }
    }
}
