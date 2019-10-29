﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHandling1
{
    class OverrideMethod
    {
        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        public void Print(double value)
        {
            Console.WriteLine(value);
        }

        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class GenericMethod
    {
        public void Print<T>(T value) //T = 타입
        {
            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OverrideMethod om = new OverrideMethod();
            om.Print(100);
            om.Print(3.14);
            om.Print("GSM");

            Console.Write('\n');

            GenericMethod gm = new GenericMethod();
            gm.Print<int>(100);
            gm.Print<double>(3.14);
            gm.Print<string>("연진");
        }
    }
}