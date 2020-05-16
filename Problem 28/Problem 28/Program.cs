using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_28
{
    class Program
    {

        /// <summary>
        /// Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed.
        /// It can be verified that the sum of the numbers on the diagonals is 101.
        /// What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
        /// Answer : 669167000
        /// </summary>

        static void Main(string[] args)
        {
            long sum = 0;
            int toAdd = 2;
            int count = 1;

            long i = 1;
            while (i < 1002001)
            {
                sum += i;
                i += toAdd;
                count++;
                if (count == 4)
                {
                    toAdd += 2;
                    count = 0;
                }
            }

            Console.WriteLine(toAdd);
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
