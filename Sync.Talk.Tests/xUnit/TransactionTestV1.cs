using Domain.Transaction;
using System;
using Xunit;

namespace Tests.UnitTests
{
    /*
                NUnit               MSTest          Xunit

    Classe:     [TestFixture]       [TestClass]         

    Método:     [Test]	            [TestMethod]	[Fact]
            
    */

    public class TransactionTestV1
    {
        [Fact]
        public void ShoudReturnAmount100()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Assert
            Assert.Equal(100, transaction.Amount);
        }

        [Fact]
        public void ShoudReturnAmount200()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Act
            transaction.Sum(100);

            // Assert
            Assert.Equal(200, transaction.Amount);
        }
    }
}