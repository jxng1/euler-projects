using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18
{
    class Program
    {

        /// <summary>
        /// By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.
        /// That is, 3 + 7 + 4 + 9 = 23.
        /// Find the maximum total from top to bottom of the triangle.
        /// Answer: 1074
        /// </summary>

        static void Main(string[] args)
        {

            int[,] triangle = new int[,]
            { { 75 ,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
              {95, 64 ,0,0,0,0,0,0,0,0,0,0,0,0,0},
              { 17,47,82,0,0,0,0,0,0,0,0,0,0,0,0},
              { 18,35,87,10,0,0,0,0,0,0,0,0,0,0,0},
              { 20,04,82,47,65,0,0,0,0,0,0,0,0,0,0},
              {19,01,34,75,03,34,0,0,0,0,0,0,0,0,0 },
              {88,02,77,73,07,63,67 ,0,0,0,0,0,0,0,0},
              {99,65,04,28,06,16,70,92,0,0,0,0,0,0,0 },
              {41,41,26,56,83,40,80,70,33,0,0,0,0,0,0 },
              {41,48,72,33,47,32,37,16,94,29,0,0,0,0,0 },
              {53,71,44,65,25,43,91,52,97,51,14,0,0,0,0 },
              {70, 11 ,33 ,28, 77, 73 ,17 ,78, 39 ,68 ,17 ,57,0,0,0 },
              {91 ,71 ,52, 38 ,17 ,14, 91, 43, 58, 50, 27, 29, 48,0, 0 },
              { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31,0},
              { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
            };

            int lines = triangle.GetLength(0);

            for (int i = lines - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    triangle[i, j] += Math.Max(triangle[i + 1, j], triangle[i + 1, j + 1]);
                }
            }

            Console.WriteLine(triangle[0, 0]);
            Console.ReadLine();

        }



    }
}
