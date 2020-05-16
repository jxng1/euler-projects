using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_24
{
    class Program
    {

        /// <summary>
        /// A permutation is an ordered arrangement of objects. 
        /// For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
        /// If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. 
        /// The lexicographic permutations of 0, 1 and 2 are:
        /// 012   021   102   120   201   210
        /// What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
        /// Answer : 
        /// </summary>

        static void Main(string[] args)
        {

            int[] permutation = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int count = 1;
            int permToFind = 1000000;

            while (count < permToFind)
            {
                int len = permutation.Length;
                int i = len - 1;
                while (permutation[i - 1] >= permutation[i])
                {
                    i -= 1;
                }
                int j = len;
                while (permutation[j - 1] <= permutation[i - 1])
                {
                    j -= 1;
                }
                Program p = new Program();
                p.Swap(permutation, i, j);


            }


        }

        private void Swap(int[] permutation, int i, int j)
        {
            int k = permutation[i];
            permutation[i] = permutation[j];
            permutation[j] = k;
        }
    }
}
