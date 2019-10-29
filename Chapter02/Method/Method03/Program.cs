using System;

namespace Method03
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref를 이용한 참조에 의한 매개변수 전달
            int x = 3, y = 4;
            Console.WriteLine($"x: {x}, y: {y}");
            //Swap() 메서드를 만들어 ref로 x와 y의 값의 바뀌도록 하시오.
            Swap(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");

            //out을 이용한 몫과 나머지 구하기
            int a = 20, b = 3;
            //Divide() 함수 구현 : quotient, remainder 변수 생성
            Divide(a, b, out int quotient, out int remainder);
            Console.WriteLine($"a: {a}, v:{b}, a/b: {quotient}, a%b: {remainder}");

        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        private static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}
