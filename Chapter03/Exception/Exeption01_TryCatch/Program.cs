using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Try~ Catch */
namespace Exception01_TryCatch
{
    class Program
    {
        static int[] arr = { 1, 2, 3 };

        //배열 출력
        static void ExceptionMethod()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine("ExceptionMethod() 종료");
        }

        static void TryCatchMethod()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("예외가 발생함");
                Console.WriteLine($"에러 메시지:{e.Message}");
            }

            Console.WriteLine("ExceptionMethod() 종료");
        }

        static void Main(string[] args)
        {
            //Exception();
            TryCatchMethod();
        }
    }
}