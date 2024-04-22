using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_57_Kiet_Truong_KTPM_MSUnit
{
    public class CircleCalculator
    {
        public class Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        public class Circle
        {
            public Point Center { get; }
            public double Radius { get; }

            public Circle(Point center, double radius)
            {
                Center = center;
                Radius = radius;
            }
            public static class CircleUtils
            {
                public static string KiemTraDiem(Circle circle, Point point)
                {

                    double dx = circle.Center.X - point.X;
                    double dy = circle.Center.Y - point.Y;
                    double temp = Math.Sqrt(dx * dx + dy * dy);
                    if (temp > circle.Radius)
                    {
                        return "Ngoai";
                    }
                    else if (temp < circle.Radius)
                    {
                        return "Trong";
                    }
                    else
                    {
                        return "Tren";
                    }
                }
            }
        }
    }
}
