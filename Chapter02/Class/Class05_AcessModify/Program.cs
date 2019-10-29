﻿using System;

namespace Class05_AcessModify
{
    class A
    {
        public int value1 = 10;
        private int value2 = 20;
        protected int value3 = 30;

        public class C : A
        {
            public int GetValue2()
            {
                return value2;
            }
        }
    }

    class B : A
    {
        public int GetValue3()
        {
            return value3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.value1);

            B b = new B();
            Console.WriteLine(b.GetValue3());

            var c = new A.C();
        }
    }
}
