using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_31
{
    class Program
    {

        /// <summary>
        /// In the United Kingdom the currency is made up of pound (£) and pence (p). There are eight coins in general circulation:
        /// 1p, 2p, 5p, 10p, 20p, 50p, £1 (100p), and £2 (200p).
        /// How many different ways can £2 be made using any number of coins?
        /// Answer: 73682 X
        /// </summary>

        static void Main(string[] args)
        {
            int target = 200;
            int[] coinSizes = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] ways = new int[target + 1];
            ways[0] = 1;

            for (int i = 0; i < coinSizes.Length; i++)
            {
                for (int j = coinSizes[i]; j <= target; j++)
                {
                    ways[j] += ways[j - coinSizes[i]];
                }
            }

            int sum = 0;
            for (int i = 0; i < ways.Length; i++)
            {
                sum += ways[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
