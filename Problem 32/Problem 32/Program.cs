using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long sum = 0;
            List<long> pandigitals = new List<long>();

            for (int a = 1; a < 9876; a++)
            {
                for (int b = 1; b < 10000 / a; b++)
                {
                    bool[] used = new bool[] { false, false, false, false, false, false, false, false, false, false };
                    long product = a * b;
                    int numOfDigits = product.ToString().Length + a.ToString().Length + b.ToString().Length;
                    if (numOfDigits.Equals(9))
                    {
                        foreach (char digit in product.ToString())
                        {
                            used[Convert.ToInt32(digit.ToString())] = true;
                        }
                        foreach (char digit in a.ToString())
                        {
                            used[Convert.ToInt32(digit.ToString())] = true;
                        }
                        foreach (char digit in b.ToString())
                        {
                            used[Convert.ToInt32(digit.ToString())] = true;
                        }
                        if (CheckBoolean(used).Equals(true) && !pandigitals.Contains(product))
                        {
                            pandigitals.Add(product);
                        }
                    }
                }
            }

            foreach (long product in pandigitals)
            {
                sum += product;
            }

            sw.Stop();
            Console.WriteLine("The sum of the products of the pandigitals are: {0}", sum);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static bool CheckBoolean(bool[] used)
        {
            for (int i = 1; i <= 9; i++)
            {
                if (used[i] == false) { return false; }
            }
            return true;
        }
    }
}
