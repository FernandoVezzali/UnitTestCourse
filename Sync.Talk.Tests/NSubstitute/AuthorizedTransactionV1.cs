using Domain.AuthorizedTransaction;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.UnitTests
{
    public class AuthorizedTransactionV1
    {
        [Fact]
        public void ShoudHandleNotImplementedException()
        {
            // Arrange
            var externalAuthorization = new ExternalAuthorization();
            var transaction = new AuthorizedTransaction(Guid.NewGuid().ToString(), DateTime.Now, 100, externalAuthorization);

            // Assert
            Assert.Throws<NotImplementedException>(() => transaction.Sum(100));
        }

        [Fact]
        public void ShoudReturnAmount200AsItsAuthorized()
        {
            // Arrange
            var externalAuthorization = Substitute.For<IExternalAuthorization>();
            externalAuthorization.IsAuthorized().Returns(true);
            var transaction = new AuthorizedTransaction(Guid.NewGuid().ToString(), DateTime.Now, 100, externalAuthorization);

            // Act
            transaction.Sum(100);

            // Assert
            Assert.Equal(200, transaction.Amount);
        }

        [Fact]
        public void ShoudReturnAmount100AsItsNotAuthorized()
        {
            // Arrange
            var externalAuthorization = Substitute.For<IExternalAuthorization>();
            externalAuthorization.IsAuthorized().Returns(false);
            var transaction = new AuthorizedTransaction(Guid.NewGuid().ToString(), DateTime.Now, 100, externalAuthorization);

            // Act
            transaction.Sum(100);

            // Assert
            Assert.Equal(100, transaction.Amount);
        }
    }
}
