using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_34
{
    class Program
    {

        /// <summary>
        /// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
        /// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
        /// Note: as 1! = 1 and 2! = 2 are not sums they are not included.
        /// Answer : 40730
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long sum = 0;

            for (int i = 11; i < 100000; i++)
            {
                int temp = 0;
                for (int length = 0; length < i.ToString().Length; length++)
                {
                    int result = 1;
                    int number = Convert.ToInt32(i.ToString().Substring(length, 1));
                    while (number > 0)
                    {
                        result *= number;
                        number--;
                    }
                    temp += result;
                }
                if (temp.Equals(i))
                {
                    sum += i;
                }
            }

            sw.Stop();
            Console.WriteLine("The sum of the curious numbers are: {0}", sum);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
