using System;

namespace WpfBankApp.BAL
{
   public  class CloseAccount:Operation
    {  
        public CloseAccount(Employee initializerOperation,Account account) : base(initializerOperation,account)
        {
        }

        public override void ApplyOperation()
        {
            if (!InitializerOperation.PermitedOperationType.Contains(OperationTypes.CloseAccount))
            {
                throw new Exception($"У сотрудника № {InitializerOperation} нет доступа ");
            }
            Account.Close();        
        }
    }
}
