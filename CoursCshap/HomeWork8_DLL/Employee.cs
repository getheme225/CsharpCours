using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork8_DLL
{
    public enum Function
    {
        Administrator,
        Cashier,
        Operator
    }

    public class Employee : Person
    {
        public bool IsBusy { get; private set; }

        public Function Function { get; }

        public BankOperation EmployeeAccesRules => BankOperationAccesRules.BankOperationAccesByEmployeeFunction(Function);

        public Employee(string name, int id, Function function) : base(name, id)
        {
            this.Function = function;
        }

        public BankOperation WorkWithClient(Client client, Account clientAccount)
        {
            IsBusy = true;
            switch (client.ClientRequieredOperation)
            {
                case RequieredOperation.Deposit:
                    return new OperationDeposit(clientAccount);
                case RequieredOperation.WithDraw:
                    return new OperationWithDraw(clientAccount);
                case RequieredOperation.CreateAccount:
                    return new CreateAccount();
            }
            return null;
        }
    }
}

