using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        /// <summary>
        ///     By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        ///     What is the 10 001st prime number?
        ///     Answer: 104743
        ///     Time taken: 2336ms
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int p = 3;
            int count = 1;
            List<int> primes = new List<int>();
            primes.Add(2);
            while (count < 10001)
            {
                bool prime = true;
                for (int i = 0; i < primes.Count; i++)
                {
                    if ((p % primes[i]).Equals(0))
                    {
                        prime = false;
                    }
                }
                if (prime == true)
                {
                    primes.Add(p);
                    count++;
                }
                p += 2;
            }
            stopwatch.Stop();
            Console.WriteLine("The 10001st prime is: {0}", primes[10000]);
            Console.WriteLine("Time taken: {0}ms", stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
