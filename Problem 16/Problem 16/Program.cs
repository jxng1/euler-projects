using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string number = "10715086071862673209484250490600018105614048117055336074437503883703510511249361224931983788156958581275946729175531468251871452856923140435984577574698574803934567774824230985421074605062371141877954182153046474983581941267398767559165543946077062914571196477686542167660429831652624386837205668069376";
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int single = Convert.ToInt32(number.Substring(i, 1));
                sum += single;
            }

            sw.Stop();
            Console.WriteLine(sum);
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
