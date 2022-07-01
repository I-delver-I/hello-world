using System;
using System.Collections;
using System.Linq;

namespace Points
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Points first = new Points(new Point[] 
            { 
                new Point(2, 4), new Point(-2, 5), new Point(-6, -1), new Point(1, -11), new Point(23, 4)
            });

            System.Console.WriteLine("The first array of points");
            PrintCollection((IEnumerable<Point>)first);

            Points second = new Points(new Point[] 
            { 
                new Point(11, 3), new Point(-21, 1), new Point(-10, -8), new Point(0, 0), new Point(9, 2)
            });

            System.Console.WriteLine("The second array of points");
            PrintCollection((IEnumerable<Point>)second);

            List<Point> points = new List<Point>();
            points.AddRange((IEnumerable<Point>)first);
            points.AddRange((IEnumerable<Point>)second);
            
            Points third = new Points(points.Where(point => point.X > 0 && point.Y > 0).ToArray());

            System.Console.WriteLine("The points of the I quarter");
            PrintCollection(third);

            double maximalDistanceBetweenPoints = third.GetMaxDistanceBetweenPoints();
            System.Console.WriteLine($"Maximal distance between points is {maximalDistanceBetweenPoints}");
        }

        static void PrintCollection(IEnumerable<Point> collection)
        {
            foreach (var item in collection)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine();
        }
    }
}