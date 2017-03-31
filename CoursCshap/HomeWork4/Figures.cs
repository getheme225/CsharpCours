using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Figures
    {
        private string name;
        public Figures(string name)
        {
            this.name = name;
        }

        public void PrintName()
        {
            Console.WriteLine(string.IsNullOrEmpty(name) ?"Не известная фигра": $"Наша фигура : {name} ");
        }

        public virtual float Perimeter()
        {
            return default(float);
        }

        public virtual float Surface()
        {
            return default(float);
        }
  }
}
