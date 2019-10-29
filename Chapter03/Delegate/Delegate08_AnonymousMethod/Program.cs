using System;

//익명 메소드 : 다시 쓸 일이 없는 경우 유용
namespace Delegate08_AnonymousMethod
{
    class Program
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(calc(3, 4));
        }
    }
}
