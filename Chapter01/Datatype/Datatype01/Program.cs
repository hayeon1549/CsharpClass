using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 값 형식의 데이터 타입
 */
namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /****** 값 형식 초기화 ******/
            // int와 System.int32가 같음(==)
            int i1, i2;
            System.Int32 i3;
            i1 = 0;
            i2 = new int(); //구조체 생성자 메소드 (초기화)
            i3 = new System.Int32();//초기화

            Console.WriteLine("{0},{1},{2}", i1, i2, i3);


            /****** bool ******/
            bool b1, b2;
            b1 = true;
            b2 = new System.Boolean();

            Console.WriteLine($"{b1},{b2}");
            Console.WriteLine(b1.GetType());

            //C# 은 0=false, 1=true (X)

            /****** 정수 숫자 형식 ******/
            int num1 = 100;
            System.Int32 num2 = 200;

            Console.WriteLine("{0}~{1}", int.MaxValue, int.MaxValue);

            // 숫자 형식 문자열 표현
            Console.WriteLine("{0,10}", 1234); // 10은 [폭 10, 오른쪽 정렬] -> 빈칸 6칸, 1234 4칸
            Console.WriteLine("{0,-10}", 1234); // 10은 [폭 10, 왼쪽 정렬] -> 1234 4칸, 빈칸 6칸
            Console.WriteLine("{0:C}", 1234); // 통화표시(\) (소,대문자 상관 X)
            Console.WriteLine("{0:d6}", 1234); // 정수 6자리로 표시

            Console.WriteLine("{0,10:d6}", 1234);

            /****** 부동 소수점 숫자 형식 ******/
            float f1 = 3.141592653589793238462643383279502884197169f; //숫자 뒤 "f"를 붙여줘야 함
            double d1 = 3.141592653589793238462643383279502884197169;  //숫자 뒤 필요없음
            decimal de1 = 3.141592653589793238462643383279502884197169m; //숫자 뒤 "m"을 붙여줘야 함

            Console.WriteLine(f1); //결과 : 3.141593
            Console.WriteLine(d1); //결과 : 3.14159265358979
            Console.WriteLine(de1); //결과 : 3.1415926535897932384626433833
            // 숫자 형식 문자열 표현
            Console.WriteLine("{0:f2}", f1);
            Console.WriteLine("{0:f3}", f1);

            Console.WriteLine(f1.GetType());
            Console.WriteLine(d1.GetType());

            /****** char(유니코드 16비트 문자) ******/
            char ch1 = 'A';
            char ch2 = (char)97; //char은 int 등의 숫자 형태로 암시적 형변환
            int number = ch1;

            Console.WriteLine(ch1);
            Console.WriteLine((int)ch1);
            Console.WriteLine(ch2);

            //System.char 메서드
            Console.WriteLine(ch1.Equals('A')); //true
            Console.WriteLine(char.IsLower(ch1)); //False

        }
    }
}