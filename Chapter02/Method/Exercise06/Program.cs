using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            FullSequenceOfLetters(text);

            void FullSequenceOfLetters(string a)
            {
                char te1 = a[0];
                char te2 = a[1];

                if (te1 <= te2)
                {
                    for (int i = te1; i <= te2; i++)
                    {
                        Console.Write((char)i);
                    }
                }
            }
        }
    }
}
