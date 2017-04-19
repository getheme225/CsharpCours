using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
    public class Client:Person
    {
        public BankOperation ClientRequieredBankOperation => BankOperationAccesRules.BankOperationByClientRequest(ClientRequieredOperation);

        public RequieredOperation ClientRequieredOperation { get; }

        public Client(string name, int id, RequieredOperation clientRequieredOperation) : base(name, id)
        {
            this.ClientRequieredOperation = clientRequieredOperation;
        }
    }
}
