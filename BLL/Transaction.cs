using System;

namespace BLL
{
    public class Transaction
    {
        public TransactionId TransactionId { get; }
        public string ProductId { get; }
        public DateTime TransactionDate { get; }
        public decimal Amount { get; }

        public Transaction(
            TransactionId transactionId,
            string productId,
            DateTime transactionDate,
            decimal amount
            )
        {
            TransactionId = transactionId;
            ProductId = productId;
            TransactionDate = transactionDate;
            Amount = amount;
        }
    }
}
