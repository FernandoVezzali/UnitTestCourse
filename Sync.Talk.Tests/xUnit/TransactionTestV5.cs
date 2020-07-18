using Domain.Transaction;
using System;
using Xunit;

namespace Tests.UnitTests.xUnit
{
    /*

    Arredondamento
            
    */

    public class TransactionTestV5
    {
        [Fact]
        public void ShouldReturnAmount16()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Act
            var result = transaction.Divide(6);

            // Assert
            Assert.Equal(16.667, result, 3);
        }
    }
}