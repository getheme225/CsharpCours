using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Door : Detail, IDoor
    {
        private static bool _isopenned;
        public readonly uint NumberOfdoor;

        public Door(uint numberOfdoor)
        {
            NumberOfdoor = numberOfdoor;
        }

        public string Open(string model)
        {
            var answer = $"Дверь № {NumberOfdoor} машины {model} " + (_isopenned ? "Открыта" : "Закрыта");
            _isopenned = !_isopenned;
            return answer;
        }

        public override double Weight { get; set; }
        public override string Name { get; set; }
    }
}
