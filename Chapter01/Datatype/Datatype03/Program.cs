﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 문자열 ↔ 숫자 변환
 */

namespace DataType03
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNum = "12345";
            int num = int.Parse(strNum);

            strNum = 12345.ToString();

            string input = Console.ReadLine();
            Console.WriteLine(input.GetType());
            int i = Convert.ToInt32(input);
            Console.WriteLine(i.GetType());
        }
    }
}