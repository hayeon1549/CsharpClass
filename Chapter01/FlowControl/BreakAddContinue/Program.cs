using System;

namespace BreakAddContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                for (int j=0; j<10; j++)
                {
                    i++;
                    if ( i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.Write("계속할까요? (y/n) ");
                string answer = Console.ReadLine();

                if (answer == "n")
                {
                    break;
                }
            }
        }
    }
}
