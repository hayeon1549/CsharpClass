using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Cat
    {
        public string name = "야용이";
        public string color;

        public Cat()
        {

        }

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }
    }
}