﻿using LogicalProgramming;
using LogicalProgramms;
using System;

namespace LogicalProgramming
{
    class Logicalproblems
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci Series \n 2. Perfect number\n 3. prime number\n 4. Reverse number\n 5. coupon number\n 6. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Logical series = new Logical();
                        series.Fibonacci();
                        break;

                        case 2:
                        LogicalProgramms.Logical num = new LogicalProgramms.Logical();
                        num.PerfectNumber();
                        break;

                    case 3:
                        Logical logical = new Logical();
                        logical.PrimeNumber();
                        break;

                    case 4:
                        Logical rev = new Logical();
                        rev.ReverseNumber();
                        break;

                    case 5:
                        Console.Write("How many numbers you wants to generate :");
                        int N = Convert.ToInt32(Console.ReadLine());
                        Logical cn = new Logical();
                        cn.CouponNumber(N);
                        break;

                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
