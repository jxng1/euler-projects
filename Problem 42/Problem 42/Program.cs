using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_42
{
    class Program
    {

        /// <summary>
        /// By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. 
        /// For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. 
        /// If the word value is a triangle number then we shall call the word a triangle word.
        /// 
        /// Using words.txt, a 16K text file containing nearly two-thousand common English words, how many are triangle words?
        /// Answer: 162
        /// </summary>

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<string> triangleWords = new List<string>();
            string csv = new StreamReader("words.txt").ReadToEnd();

            TextFieldParser parser = new TextFieldParser(new StringReader(csv));
            parser.HasFieldsEnclosedInQuotes = true;
            parser.SetDelimiters(",");

            string[] fields;
            Console.WriteLine("Triangle Words:");
            while (!parser.EndOfData)
            {
                fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    IsTriangleWord(field, triangleWords);
                }
            }
            parser.Close();

            sw.Stop();
            Console.WriteLine("Number of triangle words: {0}", triangleWords.Count);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void IsTriangleWord(string word, List<string> triangleWords)
        {
            int term = 0;
            for (int index = 0; index < word.Length; index++)
            {
                char letter = Convert.ToChar(word.Substring(index, 1));
                term += Convert.ToInt32(letter) - 64;
            }
            int c = term * 2;
            int n = 0;
            while ((Math.Pow(n, 2) + n - c) <= 0)
            {
                if ((Math.Pow(n, 2) + n) == c)
                {
                    triangleWords.Add(word);
                    Console.WriteLine(word);
                }
                n += 1;
            }

        }
    }
}
