using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class MyList
    {
        private int[] arr = new int[5];

        public int this[int index]
        {
            get { return arr[index]; }
            set
            {
                if (index >= arr.Length)
                    Console.WriteLine("index가 범위를 벗어남 .");
                else
                    arr[index] = value;
            }

        }

        public int Length
        {
            get { return arr.Length; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            // list.arr[0] = 10; //private라서 접근 불가
            myList[0] = 100;
            myList[1] = 200;

            for (int i = 0; i < myList.Length; i++)
            {
                myList[i] = (i + 1) * 100;
            }
            for (int i = 0; i < myList.Length; i++)
                Console.WriteLine(myList[i]);
        }
    }
}