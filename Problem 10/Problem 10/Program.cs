using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Problem_10
{

    /// <summary>
    ///     The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.    
    ///     Find the sum of all the primes below two million.
    ///     Answer: 142913828922
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int size = 10000000;
            bool[] isPrime = new bool[size + 1];
            for (int i = 2; i <= size; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i <= size; i++)
            {
                if (isPrime[i] == true)
                {
                    for (int j = i * 2; j <= size; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i] == true) { primes.Add(i); }
            }
            long sum = 0;
            foreach (int p in primes) { sum += p; };
            stopwatch.Stop();
            Console.WriteLine("The sum of primes under {0} is: {1}", size, sum);
            Console.WriteLine("Time taken: {0}ms", stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
