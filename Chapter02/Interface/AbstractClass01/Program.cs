using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**/
namespace AbstractClass01
{
    abstract class AbstractBase //추상 멤버가있으면 추상 클래스
    {
        public void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        protected void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Dervied.AbstractMethod()");
            PrivateMethodA();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PrivateMethodA();
        }
    }
}