using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankApp.BAL
{
   public abstract class Person
    {
        public int Number { get; private set; }
        public string Name { get; private set; }

        protected Person(int number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}
