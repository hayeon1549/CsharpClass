﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. 클래스에서 이벤트를 제공한다.
// 2. 외부에서 자유롭게 해당 이벤트를 구독하거나 해지할 수 있다.
// 3. 외부에서 구독/해지는 가능하지만, 이벤트는 오직 클래스 내부에서만 실행된다.
// 4. 이벤트의 첫 번째 인자는 이벤트를 발생시킨 인스턴스이다.
// 5. 이벤트의 두번째 인자는 해당 이벤트에 속한 의미 있는 값이다.

/* 1~n까지 값 중에 소수라고 판정될 때마다 콜백을 발생시키는 클래스 구현 */
namespace Event03_event
{

    class PrimeCB : EventArgs // 콜백 값을 담는 클래스
    {
        public int prime;
        public PrimeCB(int prime)
        {
            this.prime = prime;
        }
    }

    // 소수 생성기 클래스 : 소수가 발생할 때마다 등록된 콜백 메서드 호출
    class PrimeGenerator
    {
        public event EventHandler PrimeGenerated;

        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i) == true && PrimeGenerated != null)
                    PrimeGenerated(this, new PrimeCB(i));
            }
        }

        private bool IsPrime(int num)
        {
            if (num == 2) return true;
            for (int i = 2; i < num; i++)
                if (num % i == 0) return false;
            return true;
        }
    }

    class Program
    {
        static int sum;
        static void PrintPrime(object sender, EventArgs arg)
        {
            Console.Write((arg as PrimeCB).prime + " ");
        }

        static void SumPrime(object sender, EventArgs arg)
        {
            sum += (arg as PrimeCB).prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();
            
            // 콜백 메서드 추가
            gen.PrimeGenerated += PrintPrime;

            gen.PrimeGenerated += SumPrime;

            // 2~10까지의 소수를 판별하면서 콜백함수 호출
            gen.Run(10);
            Console.WriteLine($"sum : {sum}");

            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
        }
    }
}