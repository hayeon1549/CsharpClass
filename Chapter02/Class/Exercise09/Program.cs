using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public class Computer
    {
        private string name;
        private bool powerOn = false;

        public Computer(string name)
        {
            this.name = name;
        }

        public void Boot()
        {
            Console.WriteLine("부팅합니다.");
            powerOn = true;
        }

        public void Shutdown()
        {
            Console.WriteLine("전원을 종료합니다.");
            powerOn = false;
        }

        public void Reset()
        {
            Console.WriteLine("재부팅합니다.");
        }
    }

    public class Notebook : Computer
    {
        private int touchpadSize;

        public Notebook(int size, string name) : base(name)
        {
            touchpadSize = size;
        } 

        public void useTouchpad()
        {
            Console.WriteLine("터치패드를 사용합니다.");
            Console.WriteLine($"touchpadSize: {touchpadSize}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer("연진");
            com.Boot();
            com.Reset();
            com.Shutdown();

            Notebook note = new Notebook(50, "하연");
            note.useTouchpad();
        }
    }
}