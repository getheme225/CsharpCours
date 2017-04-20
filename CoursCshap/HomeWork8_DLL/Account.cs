using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
    public class Account
    {
        public Guid AccountNumber { get; }
        public decimal CurrentAmount { get; private set; }
        public Client AccountOwner;

        public Account(Client client)
        {
            this.AccountOwner = client;
            this.AccountNumber = Guid.NewGuid();
        }

        public void Deposite(decimal depositeAmount)
        {
            
            this.CurrentAmount += depositeAmount;      
        }

        public bool CanWithDraw(decimal withDrawAmount, out string message)
        {
            if (CurrentAmount < withDrawAmount)
            {
                message = "Недостоточно средств";
                return false;;
            }
            CurrentAmount -= withDrawAmount;
            message = $"На Счет № {AccountNumber}  списана {withDrawAmount} \n Баланс :{CurrentAmount}";
            return true;
        }
    }
}
