using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_26
{
    class Program
    {

        /// <summary>
        /// A unit fraction contains 1 in the numerator.
        /// Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
        /// Answer: 983 X
        /// </summary>

        static void Main(string[] args)
        {
            int sequenceLength = 0;

            for (int d = 1; d < 1000; d++)
            {
                int[] foundRemainders = new int[d + 1];
                int value = 1;
                int position = 0;

                while (foundRemainders[value] == 0 && value != 0)
                {
                    foundRemainders[value] = position;
                    value *= 10;
                    value %= d;
                    position++;
                }

                if (position - foundRemainders[value] > sequenceLength)
                {
                    sequenceLength = position - foundRemainders[value];
                }
            }

            Console.WriteLine(sequenceLength);
            Console.ReadLine();



        }
    }
}
