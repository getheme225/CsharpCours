using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
  public class Person
    {
        public  int ID { get; private set; }
        public  string Name { get; private set; }

        public Person(string name, int id )
        {
            this.Name = name;
            this.ID = id;
        }
    }
}
