using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> chars = input.ToList();
            chars.Sort();
            List<int> freq = new List<int>();
            char now = ' ';
            foreach (char ch in chars)
            {
                if (ch == now) freq[freq.Count-1]++;
                else
                {
                    now = ch;
                    freq.Add(1);
                }
            }


        }
    }
}
