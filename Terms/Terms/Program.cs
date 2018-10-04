using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terms
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            List<int> terms = new List<int>();

            for (int num=1; input>0; num++)
            {
                if ((input-num>=num+1)||(input==num))
                {
                    input -= num;
                    terms.Add(num);
                }
            }
            Console.WriteLine(terms.Count);
            foreach (int num in terms)
            {
                Console.Write(num + " ");
            }
            //Console.Read();
        }
    }
}
