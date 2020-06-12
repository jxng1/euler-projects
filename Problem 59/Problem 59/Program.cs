using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Problem_59
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string path = "cipher.txt";
            const int keyLength = 3;

            int[] message = File.ReadAllText(path)
                                .Split(',')
                                .Select(int.Parse).ToArray();
            int[] key = Analysis(message, keyLength);
            int[] decryptedMessage = Function(message, key);

            string output = "";
            string keyString = "";

            for (int i = 0; i < decryptedMessage.Length; i++)
            {
                output += Convert.ToChar(decryptedMessage[i]);
            }

            for (int i = 0; i < keyLength; i++)
            {
                keyString += Convert.ToChar(key[i]);
            }

            Console.WriteLine("The output string is: {0}", output);
            Console.WriteLine("The key is: {0}", keyString);
            Console.WriteLine("The sum of the ASCII values are: {0}", decryptedMessage.Sum());
            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static int[] Analysis(int[] message, int keyLength)
        {
            int maxSize = 0;
            for (int i = 0; i < message.Length; i++) { if (message[i] > maxSize) { maxSize = message[i]; } }
            int[,] piles = new int[keyLength, maxSize + 1];

            int[] key = new int[keyLength];

            for (int i = 0; i < message.Length; i++)
            {
                int index = i % 3;
                piles[index, message[i]]++;
                if (piles[index, message[i]] > piles[index, key[index]])
                {
                    key[index] = message[i];
                }
            }

            int spaceAscii = 32;
            for (int i = 0; i < keyLength; i++)
            {
                key[i] = key[i] ^ spaceAscii;
            }
            return key;
        }

        private static int[] Function(int[] message, int[] key)
        {
            int[] result = new int[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                result[i] = message[i] ^ key[i % key.Length];
            }
            return result;
        }
    }
}
