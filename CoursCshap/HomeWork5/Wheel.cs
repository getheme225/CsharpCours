using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Wheel : Detail, IRotatable
    {
        private readonly uint _numberofWheel;

        public Wheel(uint numberofWheel)
        {
            _numberofWheel = numberofWheel;
        }


        public string Move(string model)
        {
            return $"Колесо № {_numberofWheel} машины {model} вращается";
        }

        public override double Weight { get; set; }
        public override string Name { get; set; }
    }
}
