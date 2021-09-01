using System;

namespace LineAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 4;
            int y1 = 3;
            int x2 = 6;
            int y2 = 5;
            Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
        }
    }
}
