using System;

/* 참조에 의한 매개변수 전달 : in, ref, out*/

namespace Method02
{
    class Program
    {
        static void UseParams(params int[] intArr)
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine(intArr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /***** params *****/
            int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            UseParams(myIntArray);

            /***** in *****/
            int i = 44;
            InArgExample(i);
            Console.WriteLine(i);

            void InArgExample(in int inArg)
            {
                Console.WriteLine(inArg);
            }

            /***** ref : 참조에 의한 인수 전달 *****/
            //int r = 90;
            //Console.WriteLine(r);
            //RefArgExample(ref r);
            //Console.WriteLine(r);

            void RefArgExample(ref int refArg)
            {
                refArg += 10;
            }

            int x = 100, y = 3, q = 0, r = 0;
            Divide(x, y, ref q, ref r);
            Console.WriteLine("목 : {0}, 나머지 : {1}", q, r);

            void Divide(int a, int b, ref int quotieint, ref int remainder)
            {
                quotieint = a / b;
                remainder = a % b;
            }

            /***** out : 참조에 의한 인수 전달 *****/
            int outVar;
            OutArgExample(out outVar);
            Console.WriteLine(outVar);

            void OutArgExample(out int outArg)
            {
                outArg = 999;
            }

            string s = "1234";
            if(int.TryParse(s, out int result))
            {
                Console.WriteLine("result : {0}", result);
            }
            Console.WriteLine(result);

            x = 100;
            y = 3;
            outDivide(x, y, out q, out r);
            Console.WriteLine("목 : {0}, 나머지 : {1}", q, r);

            void outDivide(int a, int b, out int quotieint, out int remainder)
            {
                quotieint = a / b;
                remainder = a % b;
            }
        }
    }
}
