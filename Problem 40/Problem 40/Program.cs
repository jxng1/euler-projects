using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            StringBuilder sb = new StringBuilder();
            string decimalString = "";
            int n = 1;
            long product;

            while (sb.Length < 1e6)
            {
                sb.Append(n.ToString());
                n++;
            }

            decimalString = sb.ToString();
            product = Convert.ToInt64(decimalString.Substring(9, 1)) * Convert.ToInt64(decimalString.Substring(99, 1)) * Convert.ToInt64(decimalString.Substring(999, 1)) * Convert.ToInt64(decimalString.Substring(9999, 1)) * Convert.ToInt64(decimalString.Substring(99999, 1)) * Convert.ToInt64(decimalString.Substring(999999, 1));
            sw.Stop();
            Console.WriteLine("Product of the digits are: {0}", product);
            Console.WriteLine("Elapsed time: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
