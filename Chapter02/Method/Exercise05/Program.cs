using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            SumAndAverage(n, m);

            void SumAndAverage(int a, int b)
            {
                int sum = 0, count = 0;
                float ave = 0;

                for (int i=a; i<=b; i++)
                {
                    sum += i;
                    count++;
                }
                ave = (float)sum / count;

                Console.WriteLine("Sum : {0}, Average : {1}", sum, ave);
            }
        }
    }
}
