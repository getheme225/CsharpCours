using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Triangle :Figures        
    {
        private float firstSideLength;
        private float secondtSideLength;
        private float thirdSideLength;
        public Triangle(float firstSideLength,float secondtSideLength,float thirdSideLength, string name):base(name)
        {
            this.firstSideLength = firstSideLength;
            this.secondtSideLength = secondtSideLength;
            this.thirdSideLength = thirdSideLength;
        }

        public override float Perimeter()
        {
            return firstSideLength + secondtSideLength + thirdSideLength;
        }

        public override float Surface()
        {
            float halfOfperimeter = this.Perimeter() / 2;
            return (float)(Math.Sqrt(halfOfperimeter * ((halfOfperimeter - firstSideLength) * (halfOfperimeter - secondtSideLength) * (halfOfperimeter - thirdSideLength))));            
        }       
    }
}
