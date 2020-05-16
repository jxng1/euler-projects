using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15
{

    /// <summary>
    /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
    /// How many such routes are there through a 20×20 grid?
    /// Answer: X
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {

            const int gridSize = 20;
            long[,] grid = new long[gridSize + 1, gridSize + 1];

            //Initialise the grid with boundary conditions
            for (int i = 0; i < gridSize; i++)
            {
                grid[i, gridSize] = 1; grid[gridSize, i] = 1;
            }

            for (int i = gridSize - 1; i >= 0; i--)
            {
                for (int j = gridSize - 1; j >= 0; j--)
                {
                    grid[i, j] = grid[i + 1, j] + grid[i, j + 1];
                }
            }

            long paths = 0;
            for (int i = 0; i <= gridSize; i++)
            {
                for (int j = 0;j <= gridSize; j++)
                {
                    paths += grid[i, j];
                }
            }

            Console.WriteLine(paths);
            Console.ReadLine();










        }
    }
}
