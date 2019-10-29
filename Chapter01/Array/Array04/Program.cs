using System;

namespace Array04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 6, 7, 8 };
            jagged[2] = new int[] { 9, 10 };

            PrintArray(jagged);

            int[][] jagged2 = new int[2][]
            {
                new int[]{10, 20, 30},
                new int[]{40, 50}
            };

            PrintArray(jagged2);
        }

        private static void PrintArray(int[][] jagged)
        {
            foreach(int [] arr in jagged)
            {
                Console.Write($"Length({arr.Length}) : ");
                foreach(int e in arr)
                    Console.Write($"{e }");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
