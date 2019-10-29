using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(DateTime.Now.ToString("hh"));
            if( time <= 12)
            {
                Console.WriteLine("현재 오전 {0}시 입니다.", time);
            }
            else
            {
                Console.WriteLine("현재 오후 {0}시 입니다.", time);
            }
        }
    }
}
