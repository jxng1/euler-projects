using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_36
{
    class Program
    {

        /// <summary>
        /// The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.
        /// Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        /// (Please note that the palindromic number, in either base, may not include leading zeros.)
        /// Answer: 872187
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<int> palindromes = new List<int>();

            for (int i = 0; i <= 1000000; i++)
            {
                if (IsPalindromic(Convert.ToString(i)) == true)
                {
                    if (IsPalindromic(Convert.ToString(i, 2)) == true)
                    {
                        palindromes.Add(i);
                    }
                }
            }

            int sum = 0;
            foreach (int p in palindromes)
            {
                sum += p;
            }

            sw.Stop();
            Console.WriteLine("The sum of palindromic numbers in both denary and binary: {0}", sum);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
        private static bool IsPalindromic(string num)
        {
            string first = "", second = "";
            if ((num.ToString().Length % 2).Equals(0))
            {
                first = num.Substring(0, num.Length / 2);
                second = num.Substring(num.Length / 2, num.Length / 2);
            }
            else
            {
                first = num.Substring(0, (num.Length - 1) / 2);
                second = num.Substring(((num.Length + 1) / 2), (num.Length - 1) / 2);
            }
            char[] charArray = second.ToCharArray();
            Array.Reverse(charArray);
            if (new string(charArray).Equals(first))
            {
                return true;
            }
            return false;
        }
    }
}
