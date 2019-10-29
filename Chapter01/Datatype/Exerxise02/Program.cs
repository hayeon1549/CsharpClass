using System;

namespace Exerxise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");
            int num = int.Parse(Console.ReadLine());
            string result = num % 2 == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
