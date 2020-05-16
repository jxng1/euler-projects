using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_25
{
    class Program
    {

        /// <summary>
        /// Index of the first term in the Fibonacci sequence to have 1000 digits.        
        /// Answer: 4782
        /// </summary>


        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            BigInteger a = 1;
            BigInteger b = 1;
            int count = 1;

            while (a.ToString().Length < 1000)
            {
                BigInteger nextTerm = a + b;
                a = b;
                b = nextTerm;
                count++;
            }

            sw.Stop();
            Console.WriteLine(count);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
