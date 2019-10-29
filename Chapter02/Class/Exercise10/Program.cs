using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static double SumDoubleOnly(object[] arr)
        {
            double sum = 0;

            foreach (object i in arr)
            {
                if (i is double)
                {
                    sum += Convert.ToDouble(i);
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            object[] objectArr = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };
            Console.WriteLine(SumDoubleOnly(objectArr)); // 24.89
        }
    }
}