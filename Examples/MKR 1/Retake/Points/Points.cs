using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Points
{
    public class Points : IEnumerable<Point>
    {
        public Point[] PointsHolder { get; set; }

        public Points(Point[] pointsHolder)
        {
            PointsHolder = pointsHolder;
        }

        public Points()
        {
            
        }

        public double GetMaxDistanceBetweenPoints()
        {
            double result = 0;

            foreach (Point firstPoint in PointsHolder)
            {
                foreach (Point secondPoint in PointsHolder)
                {
                    double distanceBetweenPoints = Point.GetDistanceBetweenPoints(firstPoint, secondPoint);

                    if (distanceBetweenPoints > result)
                    {
                        result = distanceBetweenPoints;
                    }
                }
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator<Point>)PointsHolder.GetEnumerator();
        }

        IEnumerator<Point> IEnumerable<Point>.GetEnumerator()
        {
            foreach (Point point in PointsHolder)
            {
                yield return point;
            }
        }
    }
}