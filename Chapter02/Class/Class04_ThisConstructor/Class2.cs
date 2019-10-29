using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_ThisConstructor
{
    class Class2
    {
        int a, b, c;

        public Class2()
        {
            this.a = 1;
            Console.WriteLine("Class() 생성자 호출");
        }

        public Class2(int b) : this()
        {
            this.a = 1;
            Console.WriteLine($"Class(int {b}) 생성자 호출");
        }

        public Class2(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"Class(int {b}, int {c}) 생성자 호출");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}
