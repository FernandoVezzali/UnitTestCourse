using Domain.Transaction;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Xunit;
using Xunit.Abstractions;

namespace Tests.UnitTests
{
    /*

    Output
            
    */

    public class TransactionTestV7
    {
        ITestOutputHelper _output;

        public TransactionTestV7(ITestOutputHelper output)
        {
            _output = output;
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
            
            _output.WriteLine($"Final amount was {transaction.Amount}");
        }
    }
}