using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_37
{
    class Program
    {

        /// <summary>
        /// The number 3797 has an interesting property. 
        /// Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. 
        /// Similarly we can work from right to left: 3797, 379, 37, and 3.
        /// Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
        /// NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
        /// Answer: 748317
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int size = 1000000;
            bool[] primes = new bool[size + 1];

            for (int i = 2; i <= size; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i <= size; i++)
            {
                if (primes[i] == true)
                {
                    for (int j = i * 2; j <= size; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            List<int> truncatablePrimes = new List<int>();
            for (int i = 23; i <= size; i++)
            {
                if (primes[i] == true)
                {
                    if (CheckFromLeft(i, primes) == true && CheckFromRight(i, primes) == true)
                    {
                        truncatablePrimes.Add(i);
                    }
                }
            }

            int sum = 0;
            foreach (int truncatablePrime in truncatablePrimes)
            {
                sum += truncatablePrime;
            }

            sw.Stop();
            Console.WriteLine("The sum of truncatable primes are: {0}", sum);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static bool CheckFromLeft(int i, bool[] primes)
        {
            for (int index = 0; index < i.ToString().Length; index++)
            {
                string substring = i.ToString().Substring(index, i.ToString().Length - index);
                if (primes[Convert.ToInt32(substring)] != true) { return false; }
            }
            return true;
        }

        private static bool CheckFromRight(int i, bool[] primes)
        {
            for (int length = i.ToString().Length; length > 0; length--)
            {
                string substring = i.ToString().Substring(0, length);
                if (primes[Convert.ToInt32(substring)] != true) { return false; }
            }
            return true;
        }
    }
}
