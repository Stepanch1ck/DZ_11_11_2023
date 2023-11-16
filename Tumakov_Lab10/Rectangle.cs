using System;

namespace Tumakov_Lab10
{
    internal class Rectangle : Point
    {
        private int width;
        private int height;

        public Rectangle(string color, bool visible, int x, int y, int width, int height)
            : base(color, visible, x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void MoveX(int dx)
        {
            x += dx;
        }

        public override void MoveY(int dy)
        {
            y += dy;
        }

        public override void SetColor(string color)
        {
            this.color = color;
        }

        public override void IsVisible(bool visible)
        {
            this.visible = visible;
        }

        public override void Print()
        {
            Console.WriteLine("Прямоугольник:");
            Console.WriteLine($"    Цвет: {color}");
            Console.WriteLine($"    Видимость: {visible}");
            Console.WriteLine($"    Ширина: {width}");
            Console.WriteLine($"    Высота: {height}");
            Console.WriteLine($"    Координаты: {x}, {y}");
        }

        public int GetArea()
        {
            return width * height;
        }
    }
}
