using System;

namespace Zw.Geometry
{
    public static class Trigonometry
    {

        public static double Sin(Angle angle)
        {
            return Sin(angle.Radians);
        }

        public static double Sin(double radians)
        {
            return Math.Sin(radians);
        }

        public static double Cos(Angle angle)
        {
            return Cos(angle.Radians);
        }

        public static double Cos(double radians)
        {
            return Math.Cos(radians);
        }

        public static double Tan(Angle angle)
        {
            return Tan(angle.Radians);
        }

        public static double Tan(double radians)
        {
            return Math.Tan(radians);
        }

        public static double Distance(Point a, Point b)
        {
            return Distance(a.X, a.Y, b.X, b.Y);
        }

        public static double Distance(double xa, double ya, double xb, double yb)
        {
            return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
        }

        public static double Distance(Point a)
        {
            return Distance(Point.Origin, a);
        }

        public static double Distance(double x, double y)
        {
            return Distance(0, 0, x, y);
        }

        public static double GetArcLength(double circleRadius, Angle angle)
        {
            return circleRadius * angle.Radians;
            //return ((circleRadius * Math.PI * angle.Degrees) / 180);
        }
    }
}
