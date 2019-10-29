using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력>");
            int count = int.Parse(Console.ReadLine());

            int f = 0, s = 1, r = 0;
            for(int i=0; i<=count; i++)
            {
                if(i == 0)
                {
                    r = f;
                }
                else if(i ==1)
                {
                    r = s;
                }
                else
                {
                    r = f + s;
                    f = s;
                    s = r;
                }
                Console.WriteLine("FibonacciLoop( {0} ) : {1}", i, r);
            }

            f = 0;
            s = 1;
            r = 0;
            FibonacciRecursive(0, count);

            void FibonacciRecursive(int i, int cnt)
            {
                if (i == 0)
                {
                    r = f;
                }
                else if (i == 1)
                {
                    r = s;
                }
                else
                {
                    r = f + s;
                    f = s;
                    s = r;
                }
                Console.WriteLine("FibonacciRecursive( {0} ) : {1}", i, r);

                if (i != count)
                {
                    FibonacciRecursive(i + 1, cnt);
                }
            }
        }
    }
}
