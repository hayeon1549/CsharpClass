﻿using System;

namespace GenericClass02
{
    class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length { get { return array.Length; } }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> strList = new MyList<string>();
            strList[0] = "abc";
            strList[1] = "abc";
            strList[2] = "abc";
            strList[3] = "abc";
            strList[4] = "abc";

            PrintArray<string>(strList);

            MyList<int> intList = new MyList<int>();
            intList[0] = 100;
            intList[1] = 100;
            intList[2] = 100;
            intList[3] = 100;
            intList[4] = 100;

            PrintArray<int>(intList);
        }

        private static void PrintArray<T>(MyList<T> list)
        {
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine($"{list[i]}");
            Console.WriteLine();
        }
    }
}
