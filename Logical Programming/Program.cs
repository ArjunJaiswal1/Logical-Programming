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
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci Series \n 2. Perfect number\n 3. Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}
