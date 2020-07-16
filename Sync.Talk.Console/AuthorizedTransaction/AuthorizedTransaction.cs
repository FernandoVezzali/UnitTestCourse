using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AuthorizedTransaction
{
    public class AuthorizedTransaction
    {
        readonly IExternalAuthorization Authorization;

        public AuthorizedTransaction(string transactionId, DateTime transactionDate, decimal amount, IExternalAuthorization authorization)
        {
            Authorization = authorization;
            TransactionId = transactionId;
            TransactionDate = transactionDate;
            Amount = amount;
        }

        public string TransactionId { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public decimal Amount { get; private set; }
        public decimal Sum(decimal money)
        {
            if (Authorization.IsAuthorized())
            {
                Amount += money;
            }
            return Amount;
        }
    }
}
