using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    class Cube
    {
        public int x, y, z;

        public static int countOfInstance = 0;

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            countOfInstance++;
        }

        public int GetVolume()
        {
            int bupee = 0;
            bupee = x * y * z;

            return bupee;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cube Cube1 = new Cube(1, 2, 3);
            Console.WriteLine($"부피1: { Cube1.GetVolume()}");
            Cube Cube2 = new Cube(4, 5, 6);
            Console.WriteLine($"부피2: { Cube2.GetVolume()}");

            Console.WriteLine($"Cube Instance : {Cube.countOfInstance}");
        }
    }
}