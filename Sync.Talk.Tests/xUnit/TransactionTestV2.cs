using Domain.Transaction;
using System;
using Xunit;

namespace Tests.UnitTests
{
    /*
               NUnit        MSTest              Xunit

    Reúso:     [SetUp]	    [TestInitialize]	Constructor         

    */

    public class TransactionTestV2
    {
        private readonly Transaction _transaction;

        public TransactionTestV2()
        {
            _transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);
        }

        [Fact]
        public void ShoudReturnAmount100()
        {
            // Assert
            Assert.Equal(100, _transaction.Amount);
        }

        [Fact]
        public void ShoudReturnAmount200()
        {
            // Act
            _transaction.Sum(100);

            // Assert
            Assert.Equal(200, _transaction.Amount);
        }
    }
}
