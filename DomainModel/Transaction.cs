using System;

namespace DomainModel
{
    public class Transaction
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}
