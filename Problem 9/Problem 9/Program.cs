using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,       
        /// a2 + b2 = c2
        /// For example, 32 + 42 = 9 + 16 = 25 = 52.
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// Answer:
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<long> squareNumbers = new List<long>();

            for (long i = 0; Math.Pow(i, 2) < 1000000; i++) //Creates square numbers and stores them in a list.
            {
                squareNumbers.Add(Convert.ToInt64(Math.Pow(i, 2)));
            }

            int index = 1;
            bool tripletFound = false;
            while (tripletFound == false)
            {
                long a2 = squareNumbers[index];
                for (int i = index + 1; i < squareNumbers.Count; i++)
                {
                    long b2 = squareNumbers[i];
                    long sum = a2 + b2;
                    foreach (long squareNumber in squareNumbers)
                    {
                        if (sum.Equals(squareNumber))
                        {
                            int a = Convert.ToInt32(Math.Pow(a2, 0.5));
                            int b = Convert.ToInt32(Math.Pow(b2, 0.5));
                            int c = Convert.ToInt32(Math.Pow(sum, 0.5));
                            if ((a + b + c).Equals(1000))
                            {
                                tripletFound = true;
                                Console.WriteLine("Triplet found!");
                                Console.WriteLine("a:{0} b:{1} c:{2}", a, b, c);
                                Console.WriteLine("Product of abc: {0}", a * b * c);
                                stopwatch.Stop();
                                Console.WriteLine("Time taken: {0}ms", stopwatch.ElapsedMilliseconds);
                            }
                        }
                    }
                }
                index++;
            }
            Console.ReadLine();
        }
    }
}
