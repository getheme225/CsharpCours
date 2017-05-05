using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankApp.BAL
{
    public abstract class Operation
    {
        public Employee InitializerOperation { get; private set; }
        public Account Account { get; protected set; }

        protected Operation(Employee initializerOperation, Account account)
        {
            InitializerOperation = initializerOperation;
            Account = account;
        }

        public abstract void ApplyOperation();
    }
}
