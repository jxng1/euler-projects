using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_30
{
    class Program
    {

        /// <summary>
        /// Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
        /// The sum of these numbers is 1634 + 8208 + 9474 = 19316.
        /// Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
        /// Answer: 443839
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> list = new List<long>();

            for (int a = 0; a <= 9; a++)
            {
                string toTest = "abcdef";
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            for (int e = 0; e <= 9; e++)
                            {
                                for (int f = 0; f <= 9; f++)
                                {
                                    toTest = toTest.Replace('a', Convert.ToChar(Convert.ToString(a)));
                                    toTest = toTest.Replace('b', Convert.ToChar(Convert.ToString(b)));
                                    toTest = toTest.Replace('c', Convert.ToChar(Convert.ToString(c)));
                                    toTest = toTest.Replace('d', Convert.ToChar(Convert.ToString(d)));
                                    toTest = toTest.Replace('e', Convert.ToChar(Convert.ToString(e)));
                                    toTest = toTest.Replace('f', Convert.ToChar(Convert.ToString(f)));
                                    long sum = Convert.ToInt64(Math.Pow(a, 5) + Math.Pow(b, 5) + Math.Pow(c, 5) + Math.Pow(d, 5) + Math.Pow(e, 5) + Math.Pow(f, 5));
                                    long toTestLong = Convert.ToInt64(toTest);
                                    if (sum.Equals(toTestLong))
                                    {
                                        list.Add(sum);
                                    }
                                    toTest = "abcdef";
                                }
                            }
                        }
                    }
                }
            }

            long sumOfList = 0;
            foreach (long number in list)
            {
                sumOfList += number;
            }
            sumOfList--;

            sw.Stop();
            Console.WriteLine("The sum of the list: {0}", sumOfList);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}
