using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_21
{
    class Program
    {

        /// <summary>
        /// Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
        /// If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
        /// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284.  
        /// The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
        /// Evaluate the sum of all the amicable numbers under 10000.
        /// Answer: 31626
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int amicableSum = 0;
            List<string> amicablePairs = new List<string>();

            for (int n = 2; n < 10000; n++)
            {
                int m = 0;
                for (int factor = 1; factor * factor <= n; factor++)
                {
                    if ((n % factor).Equals(0))
                    {
                        m += factor;
                        if (!factor.Equals(n / factor) && !(n / factor).Equals(n))
                        {
                            m += n / factor;
                        }
                    }
                }
                int tempDivisorSum = 0;
                for (int factor = 1; factor * factor <= m; factor++)
                {
                    if ((m % factor).Equals(0))
                    {
                        tempDivisorSum += factor;
                        if (!factor.Equals(m / factor) && !(m / factor).Equals(m))
                        {
                            tempDivisorSum += m / factor;
                        }
                    }
                }
                if (tempDivisorSum.Equals(n) && !m.Equals(n) && CheckIfExists(amicablePairs, m) == false) { amicablePairs.Add(n + "      " + m); amicableSum = amicableSum + m + n; };
            }

            sw.Stop();
            Console.WriteLine("The pairs of amicable numbers are listed below:");
            foreach (string pair in amicablePairs)
            {
                Console.WriteLine(pair);
            }
            Console.WriteLine("The sum of amicable numbers are: {0}", amicableSum);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static bool CheckIfExists(List<string> pairs, int m)
        {
            bool exists = false;
            foreach (string pair in pairs)
            {
                string substring = pair.Substring(0, m.ToString().Length);
                if (substring.Equals(m.ToString()))
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
