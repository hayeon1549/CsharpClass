using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 444p예제 */
namespace Delegate09_AnonymousMethod
{
    delegate int Compare(int a, int b); // 두 값을 비교하여 정수 반환 (-1,0,1)

    class Program
    {
        static void BubbleSort(int[] DataSet, Compare Compare)
        {
            int i, j, temp;
            for (i = 0; i < DataSet.Length; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Compare(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                    PrintArray(DataSet);
                }
            }
            Console.WriteLine();
        }

        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 17, 3, 9, 2, 16 };
            Console.Write("초기 상태 : ");
            PrintArray(array);
            BubbleSort(array, delegate (int a, int b)
            {
                if (a > b) return 1;
                else if (a == b) return 0;
                else return -1;
            });

            int[] array2 = { 5, 17, 3, 9, 2, 16 };
            Console.Write("초기 상태 : ");
            PrintArray(array2);
            BubbleSort(array2, delegate (int a, int b)
            {
                if (a < b) return 1;
                else if (a == b) return 0;
                else return -1;
            });
        }
    }
}