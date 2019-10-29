﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generic Delegate
namespace Delegate05_Generic
{

    delegate int Compare<T>(T a, T b);
    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            T temp;
            for (int i = 0; i < DataSet.Length - 1; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
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

        private static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 25, 23, 12, 9, 7 };
            Console.WriteLine("초기 상태");
            PrintArray(array);
            BubbleSort(array, new Compare<int>(AscendCompare));

            double[] array2 = { 2.5, 2.3, 1.2, 9, 7 };
            Console.WriteLine("초기 상태 : ");
            PrintArray(array2);
            BubbleSort(array2, new Compare<double>(DescendCompare));
        }
    }
}