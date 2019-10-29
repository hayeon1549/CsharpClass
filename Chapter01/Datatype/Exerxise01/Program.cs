using System;

namespace Exerxise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2개의 실수를 입력하세요.");
            double fir = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", fir, sec, fir + sec);
        }
    }
}
