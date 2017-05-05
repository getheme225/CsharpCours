using System.Collections.Generic;

// ReSharper disable All

namespace WpfBankApp.BAL
{
    public class Employee : Person
    {
        public bool IsSingIn { get; private set; }
        public EmployeeFunction Function { get; }
        public string Password { get; private set; }
        public List<OperationTypes> PermitedOperationType
        {
            get
            {
                var permitionList = new List<OperationTypes>();
                switch (Function)
                {
                    case EmployeeFunction.Operator:
                        permitionList.Add(OperationTypes.Withdraw);
                        permitionList.Add(OperationTypes.Deposit);
                        break;
                    case EmployeeFunction.AccountManager:
                        permitionList.Add(OperationTypes.OpenAccount);
                        permitionList.Add(OperationTypes.CloseAccount);
                        break;
                    default:
                        permitionList.Add(OperationTypes.None);
                        break;
                }
                return permitionList;
            }
        }
    
        public Employee(int number, string name, string password,
            EmployeeFunction function)
            : base(number, name)
        {
            IsSingIn = false;
            Password = password;
            this.Function = function;
        }

        public void SingIn()
        {
            IsSingIn = true;
        }

        public void SingOut()

        {
            IsSingIn = false;
        }

    }
}
