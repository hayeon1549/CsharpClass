using System;

namespace Class07_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Dog("멍멍이");
            Mammal m2 = new Cat("야옹이");

            if(m1 is Dog) //같은 클래스 타입이면 True
            {
                Dog ddd = (Dog)m1; ;
                ddd.Bark();
            }

            //Cat cat = (Cat)m1 // 타입이 맞지 않아 에러 발생
            //Cat cat = m1 as Cat; //타입이 맞지 않는 경우 null 발생

        }

        static void Wash(Mammal mammal)
        {
            Console.WriteLine($"{mammal.GetName()}가 씻는다");
        }
    }
}
