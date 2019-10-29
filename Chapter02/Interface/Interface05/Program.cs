using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface05
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("fly fly");
        }

        public void Run()
        {
            Console.WriteLine("run run");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car;
            runnable.Run();

            IFlyable flyable = new FlyingCar();
            flyable.Fly();

            FlyingCar car2 = flyable as FlyingCar;
            car2.Run();
            car2.Fly();
        }
    }
}