using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
    public class OperationWithDraw : BankOperation
    {
        public OperationWithDraw(Account account) : base(account)
        {
        }

        public bool CanMakeWithDraw(decimal amountToWithDraw, out string message)
        {
            if (Account?.CurrentAmount > amountToWithDraw)
            {
                return Account.CanWithDraw(amountToWithDraw, out message);
            }
            message = (Account != null) ? "Недостоточно средств" : "Это Счет не сушкетсвует";
            return false;
        }
    }
}
