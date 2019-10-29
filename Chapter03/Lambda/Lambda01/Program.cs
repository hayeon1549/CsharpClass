using System;

// (input - parameters) => expression

namespace Lambda01
{
    class Program
    {
        delegate int? CalcDelegate(int a, int b);

        // 1. 제네릭 타입의 사칙연산 처리용 델리게이트 선언
        delegate T Calculator2<T>(T a, T b);

        static void Main(string[] args)
        {
            #region 람다 연습
            // 델리게이트 키워드를 사용한 무명메소드
            CalcDelegate c1 = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(c1(3, 4));

            // 람다식으로 표현한 익명메소드
            CalcDelegate c2 = (a, b) => a + b; //Delegate에 매개변수가 int 선언이 되어있으므로 생략이 가능
            Console.WriteLine(c2(3, 4));

            c2 = (a, b) =>
            {
                if (b == 0)
                    return null;
                return a / b;
            };
            Console.WriteLine(c2(10, 3));
            Console.WriteLine(c2(10, 0));
            #endregion

            // 2. 제네릭 타입의 델리게이트 참조변수 생성하면서 사칙연산 람다식 할당
            Calculator2<double> c3 = (a, b) => a + b;

            // 3. 위 참조변수로 Calc 메소드 호출
            Calc<double>(3.14, 6.56, c3);
            Calc<int>(100, 200, (a, b) => a + b);  
        }

        static void Calc<T>(T a, T b, Calculator2<T> CalcFunc)
        {
            Console.WriteLine(CalcFunc(a, b));
        }
    }
}
