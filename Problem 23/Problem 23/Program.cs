﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_23
{
    class Program
    {

        /// <summary>
        /// A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
        /// For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
        /// A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
        /// As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. 
        /// By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
        /// However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.
        /// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
        /// Answer: 4179871
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            const int limit = 28123;
            List<int> abundant = new List<int>();

            for (int n = 2; n <= limit; n++)
            {
                int sumOfFactors = 0;
                for (int factor = 1; factor * factor <= n; factor++)
                {
                    if (n % factor == 0 && factor != n)
                    {
                        sumOfFactors += factor;
                        if (factor != n / factor && n / factor != n)
                        {
                            sumOfFactors += n / factor;
                        }
                    }
                }
                if (sumOfFactors > n)
                {
                    abundant.Add(n);
                }
            }

            bool[] canBeAbundant = new bool[limit + 1];
            for (int i = 0; i < abundant.Count; i++)
            {
                for (int j = i; j < abundant.Count; j++)
                {
                    if (abundant[i] + abundant[j] <= limit)
                    {
                        canBeAbundant[abundant[i] + abundant[j]] = true;
                    }
                    else { break; } //leave loop if sum above 28123 as there's no other sums;
                }
            }

            int sumOfNonAbundants = 0;
            for (int i = 0; i < canBeAbundant.Length; i++)
            {
                if (canBeAbundant[i] == false)
                {
                    sumOfNonAbundants += i;
                }
            }

            sw.Stop();
            Console.WriteLine("The sum of non-abundants are: {0}", sumOfNonAbundants);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}
