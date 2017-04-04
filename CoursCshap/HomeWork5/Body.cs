using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Body : Detail, IRotatable, IDoor
    {
        public string Move(string model)
        {
            return $"Машина {model} едет";
        }

        public string Open(string model)
        {
            return "Увы, это не дверь";
        }

        public override double Weight { get; set; }
        public override string Name { get; set; }
    }
}
