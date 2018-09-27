using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    //проверка на входные даннные не осуществляется в связи с уверенности корректности автоматических тестов сиситемы
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Int64 num = Int64.Parse(input[0]);
            int mod = Int32.Parse(input[1]);
            Console.WriteLine(GetFibonacci(num,mod));
            Console.Read();
        }

        static int GetFibonacci(int num)
        {
            int[] items = new int[num + 1];
            items[0] = 0;
            items[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                items[i] = items[i - 1] + items[i - 2];
            }
            return items[num];
        }
        static int GetFibonacci(Int64 num, int mod)
        {
            List<int> periodPizano = GetPeriodPizano(mod);
            checked
            {
                return periodPizano[(int)(num % periodPizano.Count)];
            }
        }
        static List<int> GetPeriodPizano (int mod)
        {
            List<int> mods = new List<int>();
            mods.Add(0);
            mods.Add(1);
            while (true)
            {
                int next = (mods[mods.Count-1] + mods[mods.Count - 2]) % mod;
                mods.Add(next);
                if  ((mods[mods.Count-1]==1)&&(mods[mods.Count-2]==0))
                {
                    mods.RemoveRange(mods.Count - 2, 2);
                    return mods;
                }                
            }
        }

    }
}
