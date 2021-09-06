using System;
using System.Collections.Generic;
using System.Text;

namespace LineAndComparison
{
    class CustomLines
    {
        int x1 = 4;
        int y1 = 3;
        int x2 = 6;
        int y2 = 5;
        double length1;
        double length2;
        int m1 = 4;
        int n1 = 3;
        int m2 = 6;
        int n2 = 5;
        public void checkLines()
        {
            length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            length2 = Math.Sqrt((m2 - m1) * (m2 - m1) + (n2 - n1) * (n2 - n1));
            Console.WriteLine(length1);
            Console.WriteLine(length2);
            Console.WriteLine($"Equals Method : {length1.ToString().Equals(length2.ToString())}");//Return TRUE if lines are equal otherwise false
            Console.WriteLine($"CompareTo Method : {length1.CompareTo(length2)}");
            if (length1 > length2)
            {
                Console.WriteLine("Line 1 is Greater!");
            }
            else if (length1 == length2)
            {
                Console.WriteLine("Both Lines are Equals!");
            }
            else
            {
                Console.WriteLine("Line 2 is Greater!");
            }
        } 
    }
}
