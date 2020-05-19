using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_35
{
    class Program
    {

        /// <summary>
        /// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
        /// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
        /// How many circular primes are there below one million?
        /// Answer: 55
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

            List<int> primesList = new List<int>();
            for (int i = 2; i <= size; i++)
            {
                if (primes[i] == true) { primesList.Add(i); }
            }

            List<int> circularPrimes = new List<int>();
            foreach (int prime in primesList)
            {
                int length = prime.ToString().Length;
                int pointer = 0;
                bool valid = true;
                while (pointer < length && valid == true)
                {
                    int permutation = Convert.ToInt32(prime.ToString().Substring(pointer, length - pointer) + prime.ToString().Substring(0, pointer));
                    if (!primes[permutation] == true) { valid = false; }
                    pointer++;
                }
                if (valid == true) { circularPrimes.Add(prime); }
            }

            sw.Stop();
            Console.WriteLine("Number of circular primes under 1000000: {0}", circularPrimes.Count);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
