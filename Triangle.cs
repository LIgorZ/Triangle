using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        
        // Поля: int a, b, c;
        int a, b, c;

        //Конструктор, позволяющий создать экземпляр класса  с заданными длинами сторон.
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle() { }

        // Методы, позволяющие: вывести длины сторон треугольника на экран;
        public void Show() { Console.WriteLine("Треугольник со сторонами а = {0}, b = {1}, c = {2}", a, b, c); }

        //расчитать периметр треугольника;
        public int Perimeter() { return a + b + c; }

        // расчитать площадь треугольника
        public double Area()
        {
            double HalfPerim = (double)(a + b + c) / 2;
            return Math.Sqrt(HalfPerim * (HalfPerim - a) * (HalfPerim - b) * (HalfPerim - c));
        }

        // Свойства: позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи);
        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public int C
        {
            get { return c; }
            set { c = value; }
        }

        // позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения).
        public bool isTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                    return true;
                return false;
            }
        }

        // Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к полю b, по индексу 2 – к полю c, при других значениях индекса выдается сообщение об ошибке.
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 1:
                        return a;
                    case 2:
                        return b;
                    case 3:
                        return c;
                    default:
                        throw new Exception("Error");
                }
            }
        }

    }
}
