using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {

            int n1 = 10, n2 = 20;
            char c1 = 'A', c2 = 'Z';
            string s1 = "Hello", s2 = "World";
            Console.WriteLine($"n1={n1},n2={n2}");
            Swap<int>(ref n1, ref n2);
            Console.WriteLine($"n1={n1},n2={n2}");

            Console.WriteLine($"c1={c1},c2={c2}");
            Swap<char>(ref c1, ref c2);
            Console.WriteLine($"c1={c1},c2={c2}");

            Console.WriteLine($"s1={s1},s2={s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1={s1},s2={s2}");
        }
    }
}