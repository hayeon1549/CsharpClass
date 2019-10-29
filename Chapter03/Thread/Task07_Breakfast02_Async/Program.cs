using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task07_MakeBreakfast02_Async
{
    internal class Toast
    {
    }
    internal class Bacon
    {
    }
    internal class Egg
    {
    }
    internal class Juice
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** 아침 식사 준비 시작 *****\n");

            DateTime startTime = DateTime.Now;

            Task<Egg> fryEggsTask = FryEggs(2);
            var fryBaconTask = FryBacon(3);
            var toastBreadTask = MakeToastWithButterAndJamAsync(2);

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            fryEggsTask.Wait(); // 해당 비동기 처리가 끝날 때까지 기다림.
            Console.WriteLine("eggs are ready");
            fryEggsTask.Wait();
            Console.WriteLine("bacon is ready");
            toastBreadTask.Wait();
            Console.WriteLine("toast is ready");

            Console.WriteLine("Breakfast is ready!");
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime; // 두 날짜 사이의 시간 간격 저장
            Console.WriteLine($"실행 시간 : {elapsed}");
        }
        
        async static Task<Toast> MakeToastWithButterAndJamAsync (int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);
            return toast;
        }

        private static void ApplyJam (Toast toast)
        {
            Console.WriteLine("빵에 잼을 바른다!");
            Thread.Sleep(1000);
        }

        private static void ApplyButter (Toast toast)
        {
            Console.WriteLine("빵에 버터를 바른다!");
            Thread.Sleep(1000);
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("오렌지 주스를 따른다.");
            Thread.Sleep(1000);
            return new Juice();
        }

        async private static Task<Egg> FryEggs (int count)
        {
            Console.WriteLine("계란 준비");

            await Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"계란 후라이 만들기 {i}");
                    Thread.Sleep(1000);
                }
            });

            return new Egg();
        }

        async private static Task<Bacon> FryBacon (int count)
        {
            Console.WriteLine("베이컨 준비");
            Bacon bacon = new Bacon();

            await Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"베이컨 굽기 {i}");
                    Thread.Sleep(1000);
                }
            });

            return bacon;
        }

        async private static Task<Toast> ToastBreadAsync (int count)
        {
            Console.WriteLine("토스트 준비");
            Toast toast = new Toast();

            await Task.Run(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"토스트 굽기 {i}");
                    Thread.Sleep(1000);
                }
            });

            return toast;
        }
    }
}