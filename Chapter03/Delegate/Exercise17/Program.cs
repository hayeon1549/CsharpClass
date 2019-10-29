using System;

namespace Exercise17
{
    delegate double AreaDelegate(double w, double h);

    class ShapeArea
    {
        public static void PrintShapeArea(string name, double a, double b, AreaDelegate areaDelegate)
        {
            Console.WriteLine($"{name} 도형의 넓이 : {areaDelegate(a, b)}");
        }
    }

    class Program
    {
        public static double RectangleArea(double w, double h)
        {
            return w * h;
        }

        public static double TriangleArea(double w, double h)
        {
            return 0.5 * w * h;
        }

        static void Main(string[] args)
        {
            AreaDelegate ad1 = new AreaDelegate(RectangleArea);
            ShapeArea.PrintShapeArea("사각형", 20, 30, ad1);

            AreaDelegate ad2 = new AreaDelegate(TriangleArea);
            ShapeArea.PrintShapeArea("삼각형", 20, 30, ad2);
        }
    }
}
