using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsOnSegments
{
    class Segment :IComparable
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Segment(int start,int end)
        {
            Start = start;
            End = end;
        }
        public int CompareTo(object obj)
        {
            Segment otherSegment = (Segment)obj;
            if (this.End < otherSegment.End)
                return -1;
            else if (this.End == otherSegment.End)
                return 0;
            else return 1;
        }

    }
    class Program
    {
        static List<Segment> Read()
        {
            int numSegments = Int32.Parse(Console.ReadLine());
            List<Segment> segments = new List<Segment>();
            for (int number=0; number<numSegments; number++)
            {
                string[] input = Console.ReadLine().Split(' ');
                segments.Add(new Segment(Int32.Parse(input[0]), Int32.Parse(input[1])));
            }
            return segments;
        }
        static void Main(string[] args)
        {
            List<Segment> segments = Read();
            List<int> points = new List<int>();
            segments.Sort();
            while (segments.Count != 0)
            {
                points.Add(segments.First().End);
                int num = 0;
                while (num<segments.Count)
                {
                    if (segments[num].Start <= points.Last()) segments.Remove(segments[num]);
                    else num++;
                }
            }
            Console.WriteLine(points.Count);
            foreach (int point in points)
            {
                Console.Write(point + " ");
            }
            //Console.Read();
        }
    }
}
