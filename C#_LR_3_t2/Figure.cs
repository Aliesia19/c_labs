using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C__LR_3_t2
{
    internal class Figure
    {
            private Point[] points;

            public Figure(params Point[] points)
            {
                if (points.Length < 3 || points.Length > 5)
                {
                    throw new ArgumentException("A figure must have 3 to 5 points");
                }
                this.points = points;
            }

            private double LengthSide(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }

            public void PerimeterCalculator()
            {
                double perimeter = 0;
                for (int i = 0; i < points.Length; i++)
                {
                    perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
                }
                Console.WriteLine($"Perimeter of the figure: {perimeter}");
            }
    }
}
