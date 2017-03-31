using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Rectangle:Figures
    {
        private float lengthOfTheRectangle;
        private float widthOftheRectangle;
        public Rectangle(float length,float width,string name):base(name)
        {
            this.lengthOfTheRectangle = length;
            this.widthOftheRectangle = width;
        }

        public override float Perimeter()
        {
            return lengthOfTheRectangle + widthOftheRectangle;
        }

        public override float Surface()
        {
            return lengthOfTheRectangle * widthOftheRectangle;
        }
    }
}
