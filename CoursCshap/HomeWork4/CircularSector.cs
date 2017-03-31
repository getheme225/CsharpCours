using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
   public class CircularSector: Figures
    {
        private float arcLength;
        private float radiusOfCircle;
        public CircularSector(float arcLength,float radiusOfCircle,string name):base(name)
        {
            this.radiusOfCircle = radiusOfCircle;
            this.arcLength = arcLength;
        }

        public override float Perimeter()
        {
            return arcLength * 2 *radiusOfCircle;
        }

        public override float Surface()
        {
            return arcLength * radiusOfCircle / 2;
        }
    }
}
