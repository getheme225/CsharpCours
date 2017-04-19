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
        public decimal CurrentAmount { get; set; }
        public Client AccountOwner;

        public Account(Client client)
        {
            this.AccountOwner = client;
            this.AccountNumber = Guid.NewGuid();
        }
    }
}
