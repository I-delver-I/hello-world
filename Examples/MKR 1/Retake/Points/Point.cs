using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Points
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double GetDistanceBetweenPoints(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}