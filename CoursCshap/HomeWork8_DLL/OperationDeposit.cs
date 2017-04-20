using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
    public class OperationDeposit : BankOperation
    {
        public override Guid CodeOperation => Guid.NewGuid();

        public OperationDeposit(Account account) : base(account)
        {
        }

        public bool CanMakeDeposit(decimal depositAmount, out string message)
        {
            if (Account == null)
            {
                message = "Счет не существует";
                return false;
            }
            Account.Deposite(depositAmount);
            message = $" Счет №: {Account.AccountNumber} попопльнен на {depositAmount}";
            return true;
        }
    }
}
