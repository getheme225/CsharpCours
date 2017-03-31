using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figures rectangle = new Rectangle(2, 3, "Прямоугольник");
            rectangle.PrintName();
            Console.WriteLine("Периметр : " + rectangle.Perimeter());
            Console.WriteLine("Площад : " + rectangle.Surface() + "\n");

            Figures triangle = new Triangle(10, 20, 25, "Треугольник");
            triangle.PrintName();
            Console.WriteLine("Периметр : " + triangle.Perimeter());
            Console.WriteLine("Площад : " + triangle.Surface() + "\n");

            Figures circle = new Circle(5, "Круг");
            circle.PrintName();
            Console.WriteLine("Периметр : " + circle.Perimeter());
            Console.WriteLine("Площад : " + circle.Surface() + "\n");

            Figures circularSector = new CircularSector(2, 5, "Сектор");
            circularSector.PrintName();
            Console.WriteLine("Периметр : " + circularSector.Perimeter());
            Console.WriteLine("Площад : " + circle.Surface() + "\n");
            Console.Read();
        }
    }
}
