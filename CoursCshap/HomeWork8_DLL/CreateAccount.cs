using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
   public class CreateAccount:BankOperation
    {
        public Account CreateNewAccount(Client newClient)
        {
           return new Account(newClient);
        }
    }

}
