﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = SumOfDigitOfNumbers(1, 100);
            Console.WriteLine(res);
        }
        static int SumOfDigitOfNumbers(int left, int right)
        {
            int sum = 0;
            for (int number = left; number <= right; number++)
            {
                int tmp = number;
                while (tmp > 0)
                {
                    if (tmp % 2 == 0)
                        sum += tmp % 10;
                    tmp /= 10;
                }
            }
            return sum;
        }
    }
}
