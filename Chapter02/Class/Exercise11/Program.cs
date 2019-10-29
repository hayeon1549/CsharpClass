using System;

namespace Exercise11
{
    class Shape
    {
        protected int width, height;

        public Shape(int a=0, int b=0)
        {
            width = a;
            height = b;
        }

        public virtual int area()
        {
            Console.WriteLine("도형의 넓이 : ");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a, int b) : base(a, b)
        {

        }
        
        override public int area()
        {
            int area;
            area = width * height;

            return area;
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a, int b) : base(a, b)
        {

        }

        override public int area()
        {
            double area;
            area = 0.5 * width * height; //(1/2) * width * height

            return (int)area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            PrintArea(r);
            PrintArea(t);

            void PrintArea(Shape s)
            {
                if( s is Rectangle)
                {
                    Console.WriteLine($"사각형의 넓이 : {s.area()}");
                    Console.WriteLine();
                }
                else if( s is Triangle)
                {
                    Console.WriteLine($"삼각형의 넓이 : {s.area()}");
                    Console.WriteLine();
                }
               
            }
        }
    }
}
