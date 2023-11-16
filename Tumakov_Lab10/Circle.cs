using System;

namespace Tumakov_Lab10
{
    internal class Circle : Point
    {
        private double radius;

        public Circle(string color, bool visible, int x, int y, int radius)
            : base(color, visible, x, y)
        {
            this.radius = radius;
        }

        public override void Print()
        {
            Console.WriteLine("Окружность:");
            Console.WriteLine($"    Цвет: {color}");
            Console.WriteLine($"    Видимость: {visible}");
            Console.WriteLine($"    Радиус: {radius}");
            Console.WriteLine($"    Координаты: {x}, {y}");
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
