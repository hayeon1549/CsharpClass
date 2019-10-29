using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class NameCard
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();

            MyCard.Name = "상현";
            MyCard.Age = 24;

            Console.WriteLine($"Name:{MyCard.Name}");
            Console.WriteLine($"Age:{MyCard.Age}");
        }
    }
}