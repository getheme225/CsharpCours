using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
    public static class BankOperationAccesRules
    {
        public static BankOperation BankOperationAccesByEmployeeFunction(Function employeeFunction)
        {
            switch (employeeFunction)
            {
                case Function.Administrator:
                    return new CreateAccount();
                case Function.Cashier:
                    return new OperationWithDraw(null);
                case Function.Operator:
                    return new OperationDeposit(null);
            }
            return null;
        }

        public static BankOperation BankOperationByClientRequest(RequieredOperation operation)
        {
            switch (operation)
            {
                case RequieredOperation.Deposit:
                    return new OperationDeposit(null);
                case RequieredOperation.WithDraw:
                    return new OperationWithDraw(null);
                case RequieredOperation.CreateAccount:
                    return new CreateAccount();
            }
            return null;
        }
    }
}
