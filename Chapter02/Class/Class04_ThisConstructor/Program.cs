﻿using System;

namespace Class04_ThisConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본 생성자 사용
            {
                Class1 a1 = new Class1();
                a1.PrintFields();

                Class1 a2 = new Class1(2);
                a2.PrintFields();

                Class1 a3 = new Class1(2, 3);
                a1.PrintFields();
            }
            Console.WriteLine();

            // this() 생성자 사용
            {
                Class2 a1 = new Class2();
                a1.PrintFields();

                Class2 a2 = new Class2(2);
                a2.PrintFields();

                Class2 a3 = new Class2(2, 3);
                a1.PrintFields();
            }
        }
    }
}
