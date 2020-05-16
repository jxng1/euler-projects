using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_22
{
    class Program
    {

        /// <summary>
        /// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. 
        /// Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
        /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
        /// So, COLIN would obtain a score of 938 × 53 = 49714.
        /// What is the total of all the name scores in the file?
        /// Answer: 871198282
        /// </summary>
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            const string path = "names.txt";

            TextFieldParser parser = new TextFieldParser(path);

            parser.HasFieldsEnclosedInQuotes = true;
            parser.SetDelimiters(",");

            List<string> names = new List<string>();
            string[] fields;

            while (!parser.EndOfData)
            {
                fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    names.Add(field);
                }
            }
            names.Sort();
            long total = 0;
            int count = 1;
            foreach (string name in names)
            {
                long score = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    score += Convert.ToInt32(Convert.ToChar(name.Substring(i, 1)) - 64);
                }
                score *= count;
                total += score;
                count++;
            }

            sw.Stop();
            Console.WriteLine("The total of the sum of first names are: {0}", total);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
