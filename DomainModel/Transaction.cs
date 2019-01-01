using System;

namespace DomainModel
{
    public class Transaction
    {
        public TransactionId TransactionId { get; set; }
        public string ProductId { get; set; }
        public DateTime TransactionDate { get; }
        public decimal Amount { get; set; }

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
