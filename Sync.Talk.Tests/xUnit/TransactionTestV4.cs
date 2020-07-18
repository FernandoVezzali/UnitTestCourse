using Domain.Transaction;
using System;
using Xunit;

namespace Tests.UnitTests.xUnit
{
    /*

    [Theory] Atribute
    [InLineData(1,2,3)] // tem que ser estaticos (constante, enum, valor) objetos complexos nao funciona
            
    */

    public class TransactionTestV4
    {
        [Theory]
        [InlineData(100, 200)]
        [InlineData(200, 300)]
        [InlineData(-100, 0)]
        public void ShouldReturnCorrectAmount(int amountToSum, int expectedResult)
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Act
            transaction.Sum(amountToSum);

            // Assert
            Assert.Equal(expectedResult, transaction.Amount);
        }
    }
}