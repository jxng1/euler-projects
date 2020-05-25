using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int size = 7654321;
            bool[] primeSieve = new bool[size + 1];

            for (int i = 2; i <= size; i++)
            {
                primeSieve[i] = true;
            }

            for (int i = 2; i <= size; i++)
            {
                if (primeSieve[i] == true)
                {
                    for (int j = i * 2; j <= size; j += i)
                    {
                        primeSieve[j] = false;
                    }
                }
            }

            for (int i = size; i >= 2; i--)
            {
                if (primeSieve[i] == true && IsPandigital(i.ToString()) == true) { Console.WriteLine(i); break; }
            }

            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
        private static bool IsPandigital(string num)
        {
            for (int i = 1; i <= num.Length; i++)
            {
                if (!num.Contains(Convert.ToString(i))) { return false; }
            }
            return true;
        }

    }
}
