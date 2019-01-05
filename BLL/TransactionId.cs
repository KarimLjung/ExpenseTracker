namespace BLL
{
    public struct TransactionId
    {
        public string Value { get; }

        public TransactionId(string id)
        {
            Value = id;
        }
    }
}
