namespace WpfBankApp.BAL
{
    public abstract class MonetaryOperation:Operation
    {
        public decimal Amount { get; private set; }

        protected MonetaryOperation(Employee initializerOperation, Account account, decimal amount)
            : base(initializerOperation, account)
        {
            Amount = amount;
        }

    }
}
