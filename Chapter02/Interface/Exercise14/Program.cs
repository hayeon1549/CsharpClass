using System;

namespace Exercise14
{
    class Program
    {
        interface ITransaction
        {
            string ProductName { get; set; }
            DateTime TransactionDate { get; set; }
            int TransationAmount { get; set; }
        }

        class Transaction
        {
            public string ProductName { get; set; }
            public DateTime TransactionDate { get; set; } = DateTime.Now;
            public int TransationAmount { get; set; }

            public void showTransaction()
            {
                Console.WriteLine("*****거래 정보*****");
                Console.WriteLine($"ProductName: {ProductName}");
                Console.WriteLine($"TransactionDate: {TransactionDate}");
                Console.WriteLine($"TransactiondAmount: {TransationAmount}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Transaction t1 = new Transaction()
            {
                ProductName = "노트북",
                TransationAmount = 240
            };
            t1.showTransaction();

            Transaction t2 = new Transaction()
            {
                ProductName = "데스크탑",
                TransactionDate = new DateTime(2020, 3, 1),
                TransationAmount = 80
            };
            t2.showTransaction();
        }
    }
}