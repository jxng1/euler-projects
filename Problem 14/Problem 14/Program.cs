using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14
{
    class Program
    {

        /// <summary>
        /// The following iterative sequence is defined for the set of positive integers:
        /// n → n/2 (n is even)
        /// n → 3n + 1 (n is odd)
        /// Using the rule above and starting with 13, we generate the following sequence:
        /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
        /// Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
        /// Which starting number, under one million, produces the longest chain?
        /// NOTE: Once the chain starts the terms are allowed to go above one million.
        /// Answer: 
        /// </summary>   

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int highestCount = 0;
            int numberWithLargestCount = 0;
           
            for (int n = 2; n < 1000000; n++)
            {
                int count = 0;
                long startNumber = Convert.ToInt64(n);
                while (!startNumber.Equals(1))
                {
                    if ((startNumber % 2).Equals(0))
                    {
                        startNumber = startNumber / 2;
                        count++;
                    }
                    else if (((startNumber - 1) % 2).Equals(0))
                    {
                        startNumber = (3 * startNumber) + 1;
                        count++;
                    }
                }
                if (count > highestCount)
                {
                    highestCount = count;
                    numberWithLargestCount = n;                   
                }
            }
            sw.Stop();
            Console.WriteLine("Number that produces the most terms is: {0} with a total of {1} terms!", numberWithLargestCount, highestCount);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
