using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_ThisConstructor
{
    internal  class Class1
    {
        int a, b, c;

        public Class1()
        {
            this.a = 1;
            Console.WriteLine("Class() 생성자 호출");
        }

        public Class1(int b)
        {
            this.a = 1;
            this.b = b;
            Console.WriteLine($"Class(int {b}) 생성자 호출");
        }

        public Class1(int b, int c)
        {
            this.a = 1;
            this.b = b;
            this.c = c;
            Console.WriteLine($"Class(int {b}, int {c}) 생성자 호출");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}
