using Domain.Transaction;
using System;
using Xunit;

namespace Tests.UnitTests
{
    /*
    
    [Trait("", "")]

    dotnet test --filter Category=Sum

    */

    public class TransactionTestV3
    {
        [Fact]
        [Trait("Category", "Sum")]
        public void ShoudReturnAmount100()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Assert
            Assert.Equal(100, transaction.Amount);
        }

        [Fact]
        [Trait("Category", "Sum")]
        public void ShoudReturnAmount200()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Act
            transaction.Sum(100);

            // Assert
            Assert.Equal(200, transaction.Amount);
        }

        [Fact]
        [Trait("Category", "Subtract")]
        public void ShoudReturnAmount100WhenSubtracting()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Act
            transaction.Subtract(100);

            // Assert
            Assert.Equal(0, transaction.Amount);
        }

        [Fact]
        [Trait("Category", "Subtract")]
        public void ShoudReturnAmount200WhenSubtracting()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Act
            transaction.Subtract(200);

            // Assert
            Assert.Equal(-100, transaction.Amount);
        }
    }
}
