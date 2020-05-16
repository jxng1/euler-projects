using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_20
{
    class Program
    {

        /// <summary>
        /// n! means n × (n − 1) × ... × 3 × 2 × 1
        /// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800, and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
        /// Find the sum of the digits in the number 100!
        /// Answer: 
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            BigInteger factorial = 1;
            for (int i = 100; i > 1; i--)
            {
                factorial *= i;
            }

            int sumOfDigits = 0;
            for (int i = 0; i < factorial.ToString().Length; i++)
            {
                sumOfDigits += Convert.ToInt32(factorial.ToString().Substring(i, 1));
            }

            sw.Stop();
            Console.WriteLine("Sum of digits of 100! are: {0}", sumOfDigits);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
