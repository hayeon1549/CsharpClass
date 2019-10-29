﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal one = new Mammal();
            one.Move();

            Lion Lion = new Lion();
            Lion.Move();

            /*  자식이 부모 타입으로 암시적으로 형변한된 경우 */
            one = Lion;  // boxing
            one.Move();

            Mammal two = new Human();
            two.Move();
        }
    }
}