using System;
using Triangle;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NET.C#.04 Создание новых типов в C#");
            int a, b, c;

            Console.Write("Введите длину строны а: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите длину строны b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Введите длину строны c: ");
            c = Int32.Parse(Console.ReadLine());

            Triangle obj = new Triangle(a, b, c);
            Console.WriteLine("Вывести длины сторон треугольника на экран:");
            obj.Show();
            Console.WriteLine();

            Console.Write("Периметр треугольника: ");
            Console.WriteLine(obj.Perimeter());
            Console.WriteLine();

            Console.Write("Площадь треугольника: ");
            Console.WriteLine(obj.Area());
            Console.WriteLine();

            Console.WriteLine("Получить-установить длины сторон треугольника:");
            obj.A = 7;
            obj.B = 7;
            obj.C = 7;
            obj.Show();
            Console.WriteLine();

            Console.WriteLine("Позволяющее установить," +
                "существует ли треугольник с данными длинами сторон:");
            Console.WriteLine(obj.isTriangle);
            Console.WriteLine();
        }
    }
}
