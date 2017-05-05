using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankApp.BAL
{
   public class WithdrawOperation:MonetaryOperation
    {
        public WithdrawOperation(Employee initializerOperation, Account account, decimal amount) : base(initializerOperation, account, amount)
        {
        }

        public override void ApplyOperation()
        {
            if (!InitializerOperation.PermitedOperationType.Contains(OperationTypes.Withdraw))
            {
                throw new Exception($"У сотрудника № {InitializerOperation} нет доступа ");
            }
            Account.WithdrawMoney(Amount);         
        }
    }
}
