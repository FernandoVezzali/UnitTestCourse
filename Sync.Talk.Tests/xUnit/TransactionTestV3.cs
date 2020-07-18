using Domain.Transaction;
using System;
using Xunit;

namespace Tests.UnitTests.xUnit
{
    /*
    
    [Trait("", "")]

    dotnet test --filter Category=Sum

    */

    public class TransactionTestV3
    {
        [Fact]
        [Trait("Category", "Sum")]
        public void ShouldReturnAmount100()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Assert
            Assert.Equal(100, transaction.Amount);
        }

        [Fact]
        [Trait("Category", "Sum")]
        public void ShouldReturnAmount200()
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
        public void ShouldReturnAmount100WhenSubtracting()
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
        public void ShouldReturnAmount200WhenSubtracting()
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
