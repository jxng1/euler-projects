using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Problem_19
{

    /// <summary>
    /// You are given the following information, but you may prefer to do some research for yourself.
    /// 1 Jan 1900 was a Monday.
    /// Thirty days has September,
    /// April, June and November.
    /// All the rest have thirty-one,
    /// Saving February alone,
    /// Which has twenty-eight, rain or shine.
    /// And on leap years, twenty-nine.
    /// A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
    /// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    /// Answer:
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int day = 2;
            int date = 1;
            int sundaysOnFirst = 0;
            List<int> dateOfSundays = new List<int>();

            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    if (year % 4 == 0)
                    {
                        if (month.Equals(1) || month.Equals(3) || month.Equals(5) || month.Equals(7) || month.Equals(8) || month.Equals(10) || month.Equals(12))
                        {
                            CheckJanMarMayJulAugOctDec(date, ref day, dateOfSundays);
                        }
                        if (month.Equals(2))
                        {
                            LeapYearFeb(date, ref day, dateOfSundays);
                        }
                        if (month.Equals(4) || month.Equals(6) || month.Equals(9) || month.Equals(11))
                        {
                            CheckAprJunSepNov(date, ref day, dateOfSundays);
                        }
                    }
                    else
                    {
                        if (month.Equals(1) || month.Equals(3) || month.Equals(5) || month.Equals(7) || month.Equals(8) || month.Equals(10) || month.Equals(12))
                        {
                            CheckJanMarMayJulAugOctDec(date, ref day, dateOfSundays);
                        }
                        if (month.Equals(2))
                        {
                            NormalFeb(date, ref day, dateOfSundays);
                        }
                        if (month.Equals(4) || month.Equals(6) || month.Equals(9) || month.Equals(11))
                        {
                            CheckAprJunSepNov(date, ref day, dateOfSundays);
                        }
                    }
                }
            }

            foreach (int dateOfSunday in dateOfSundays)
            {
                if (dateOfSunday.Equals(1))
                {
                    sundaysOnFirst += 1;
                }
            }

            sw.Stop();
            Console.WriteLine("Number of Sundays on the 1st of a month is: {0}", sundaysOnFirst);
            Console.WriteLine("Total number of Sundays from 1901-2000: {0}", dateOfSundays.Count);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void CheckJanMarMayJulAugOctDec(int date, ref int day, List<int> sundays)
        {
            for (date = 1; date <= 31; date++)
            {
                if (day.Equals(7))
                {
                    sundays.Add(date);
                    day = 0;
                }
                day++;
            }
        }

        private static void LeapYearFeb(int date, ref int day, List<int> sundays)
        {
            for (date = 1; date <= 29; date++)
            {
                if (day.Equals(7))
                {
                    sundays.Add(date);
                    day = 0;
                }
                day++;
            }
        }

        private static void NormalFeb(int date, ref int day, List<int> sundays)
        {
            for (date = 1; date <= 28; date++)
            {
                if (day.Equals(7))
                {
                    sundays.Add(date);
                    day = 0;
                }
                day++;
            }
        }

        private static void CheckAprJunSepNov(int date, ref int day, List<int> sundays)
        {
            for (date = 1; date <= 30; date++)
            {
                if (day.Equals(7))
                {
                    sundays.Add(date);
                    day = 0;
                }
                day++;
            }
        }
    }
}
