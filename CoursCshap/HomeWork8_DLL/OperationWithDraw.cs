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
                Account.CurrentAmount -= amountToWithDraw;
                message =
                    $"На Счет № {Account.AccountNumber} списана {amountToWithDraw} \n Баланс :{Account.CurrentAmount}";
                return true;
            }
            message = (Account != null) ? "Недостоточно средств" : "Это Счет не сушкетсвует";
            return false;
        }
    }
}
