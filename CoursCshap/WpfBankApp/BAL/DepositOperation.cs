using System;

namespace WpfBankApp.BAL
{
   public class DepositOperation:MonetaryOperation
    {
        public DepositOperation(Employee initializerOperation, Account account, decimal amount) : base(initializerOperation, account, amount)
        {
        }

        public override void ApplyOperation()
        {
            if (!InitializerOperation.PermitedOperationType.Contains(OperationTypes.Deposit))
            {
                throw new Exception($"У сотрудника № {InitializerOperation} нет доступа ");
            }
            Account.MakeDeposite(Amount);            
        }
    }
}
