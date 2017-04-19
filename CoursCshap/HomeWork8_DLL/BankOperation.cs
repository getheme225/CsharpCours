using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
    public enum RequieredOperation
    {
        Deposit,
        WithDraw,
        CreateAccount,
    }

    public class BankOperation
    {
        public virtual Guid CodeOperation { get; protected set; }

        public Account Account { get; }

        public BankOperation(Account account)
        {
            Account = account;
        }

        protected BankOperation()
        {
        }
    }
}
