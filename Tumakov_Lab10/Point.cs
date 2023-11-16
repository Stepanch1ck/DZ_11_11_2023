using System;

namespace Tumakov_Lab10
{
    internal class Point : Figure
    {
        protected int x;
        protected int y;
        public Point(string color, bool visible, int x, int y)
            : base(color, visible)
        {
            this.x = x;
            this.y = y;
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
            Console.WriteLine("Точка:");
            Console.WriteLine($"    Цвет: {color}");
            Console.WriteLine($"    Видимость: {visible}");
            Console.WriteLine($"    Координаты: {x}, {y}");
        }
    }
}
