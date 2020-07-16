using System;

namespace Domain.Transaction
{
    public class Transaction
    {
        public Transaction(string transactionId, DateTime transactionDate, decimal amount)
        {
            TransactionId = transactionId;
            TransactionDate = transactionDate;
            Amount = amount;
        }

        public string TransactionId { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public decimal Amount { get; private set; }
        public decimal Sum(decimal money)
        {
            Amount += money;
            return Amount;
        }
        public decimal Subtract(decimal money)
        {
            Amount -= money;
            return Amount;
        }
        public double Divide(decimal money)
        {
            return (double)(Amount /money);
        }
    }
}