﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Class06_Inheritance
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base");
        }
        ~Base()
        {
            Console.WriteLine("~Base()");
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived");
        }
        ~Derived()
        {
            Console.WriteLine("~Derived()");
        }
    }
}
