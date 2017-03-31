using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
   public class Circle:Figures
    {
        private float radiusOfCircle;
        public Circle(float radius,string name):base (name)
        {
            this.radiusOfCircle = radius;
        }

        public override float Perimeter()
        {
            return  2 * (float)(Math.PI)  * radiusOfCircle ;
        }
        public override float Surface()
        {
            return (float)((Math.PI) * Math.Pow(radiusOfCircle, 2));
        }
    }
}
