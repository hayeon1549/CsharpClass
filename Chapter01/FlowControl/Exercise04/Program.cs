using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = (char)Console.Read();

            if ((a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z'))
            {
                Console.WriteLine(a + "는 알파벳입니다.");
            }
            else
            {
                Console.WriteLine(a + "는 알파벳이 아닙니다.");
            }
        }
    }
}
