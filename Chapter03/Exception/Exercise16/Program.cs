using System;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = i;

            try
            {
                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            

            
        }
    }
}
