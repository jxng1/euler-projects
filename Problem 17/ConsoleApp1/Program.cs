using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        /// <summary>
        /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
        /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
        /// Answer: X (mathematical);
        /// </summary>



        static void Main(string[] args)
        {
            int total = 0;
            total -= 30;
            for (int i = 0; i < 1000; i++)
            {
                string number = i.ToString();
                int numOfLetters = 0;

                if (number.Length > 2) ///and addition;
                {
                    numOfLetters += 3;
                }
                

                if (number.Length.Equals(4)) //Check four digit numbers;
                {
                    numOfLetters += checkThousands(number) + checkHundreds(number);
                }









                total += numOfLetters;

            }

            Console.WriteLine("Total is: {0}", total);
            Console.WriteLine("Time taken: {0}ms", 1);
            Console.ReadLine();

        }

        private static int checkThousands(string number)
        {
            int count = 0;
            switch (number.Substring(0, 1))
            {
                case "1":
                    count += 11;
                    break;
                case "2":
                    count += 11;
                    break;
                case "3":
                    count += 13;
                    break;
                case "4":
                    count += 12;
                    break;
                case "5":
                    count += 13;
                    break;
                case "6":
                    count += 11;
                    break;
                case "7":
                    count += 13;
                    break;
                case "8":
                    count += 13;
                    break;
                case "9":
                    count += 12;
                    break;
            }
            return count;
        }

        private static int checkHundreds(string number)
        {
            int count = 0;
            switch (number.Substring(1, 1))
            {
                case "1":
                    count += 10;
                    break;
                case "2":
                    count += 10;
                    break;
                case "3":
                    count += 12;
                    break;
                case "4":
                    count += 11;
                    break;
                case "5":
                    count += 11;
                    break;
                case "6":
                    count += 10;
                    break;
                case "7":
                    count += 12;
                    break;
                case "8":
                    count += 12;
                    break;
                case "9":
                    count += 11;
                    break;
            }
            return count;
        }

        private static int checkTens(string number)
        {
            IDictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("0", 4);
            dict.Add("1", 3);
            dict.Add("2", 3);
            dict.Add("3", 5);
            dict.Add("4", 4);
            dict.Add("5", 4);
            dict.Add("6", 3);
            dict.Add("7", 5);
            dict.Add("8", 5);
            dict.Add("9", 4);
            dict.Add("10", 3);
            dict.Add("11", 6);
            dict.Add("12", 6);
            dict.Add("13", 9);
            dict.Add("14", 9);
            dict.Add("15", 7);
            dict.Add("16", 7);
            dict.Add("17", 9);
            dict.Add("18", 8);
            dict.Add("19", 8);
            dict.Add("20", 6);
            
            int count = 0;

            return count;
        }


    }
}
