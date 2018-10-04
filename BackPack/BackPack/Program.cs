using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack
{
    class Thing:IComparable
    {
        public int Cost { get; set; }
        public double Volume { get; set; }

        public Thing(int cost,int volume)
        {
            Cost = cost;
            Volume = volume;
        }
        public int CompareTo(object obj)
        {
            Thing otherThing = (Thing)obj;
            double eps=0.000000000000000000000000000000001;
            if ((this.Cost / this.Volume - otherThing.Cost / otherThing.Volume) > eps) 
                return -1;
            else if ((this.Cost / this.Volume - otherThing.Cost / otherThing.Volume) < -eps)
                return 1;
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int numThings = Int32.Parse(input[0]);
            double volumeBackpack = Int32.Parse(input[1]);
            List<Thing> things = new List<Thing>();
            for (int num=0; num<numThings; num++)
            {
                input = Console.ReadLine().Split(' ');
                things.Add(new Thing(Int32.Parse(input[0]), Int32.Parse(input[1])));
            }
            things.Sort();
            
            double sum = 0;
            for (int num=0;num<numThings && volumeBackpack>0; num++)
            {
                if (things[num].Volume<volumeBackpack)
                {
                    sum += things[num].Cost;
                    volumeBackpack -= things[num].Volume;
                }
                else
                {
                    sum += things[num].Cost * volumeBackpack / things[num].Volume;
                    volumeBackpack = 0;
                }
            }
            Console.WriteLine("{0:F3}",sum);
            //Console.Read();
        }
    }
}
