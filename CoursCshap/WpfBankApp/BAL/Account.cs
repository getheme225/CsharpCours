using System;

namespace WpfBankApp.BAL
{
    public class Account
    {
        public Client Client { get; private set; }
        public bool IsClose { get; private set; }
        public decimal CurrentBalance { get; private set; }
        public int AccountNumber { get; private set; }

        public Account(Client client, int accountNumber)
        {
            Client = client;
            CurrentBalance = 0;
            AccountNumber = accountNumber;
            IsClose = false;
        }

        public void Close()
        {
            IsClose = true;
        }

        public void MakeDeposite(decimal amount)
        {
            CurrentBalance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (CurrentBalance < amount)
            {
                throw new Exception("Недостаточно средств");
            }
            CurrentBalance -= amount;
        }
    }
}
