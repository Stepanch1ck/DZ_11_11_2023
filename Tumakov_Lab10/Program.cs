using System;

namespace Tumakov_Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 10\n Упражнение 1");
            ACipher aCipher = new ACipher();
            BCipher bCipher = new BCipher();

            String text = "Привет, мир!";

            Console.WriteLine($"Исходная строка: {text}");
            Console.WriteLine($"Зашифрованная строка A: {aCipher.Encode(text)}");
            Console.WriteLine($"Расшифрованная строка A: {aCipher.Decode(aCipher.Encode(text))}");
            Console.WriteLine($"Зашифрованная строка B: {bCipher.Encode(text)}");
            Console.WriteLine($"Расшифрованная строка B: {bCipher.Decode(bCipher.Encode(text))}");

            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine(" Домашняя работа 1");
            Point point = new Point("Красный", true, 10, 20);
            point.Print();
            point.MoveX(10);
            point.SetColor("Синий");
            point.IsVisible(false);
            point.Print();

            Circle circle = new Circle("Зеленый", true, 50, 50, 10);
            circle.Print();
            double area = circle.GetArea();
            Console.WriteLine("Площадь окружности: {0}", area);

            Rectangle rectangle = new Rectangle("Желтый", true, 100, 200, 50, 100);
            rectangle.Print();
            int area2 = rectangle.GetArea();
            Console.WriteLine("Площадь прямоугольника: {0}", area2);

            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
        }
    }
}
