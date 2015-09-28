using System;

namespace Zw.Geometry
{
    public class Point
    {

        private static Point origin;

        public static Point Origin
        {
            get
            {
                return origin ?? (origin = new Point(0, 0));
            }
        }

        public Point()
        {
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point(Point source)
        {
            this.X = source.X;
            this.Y = source.Y;
        }

        public static Point operator+(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator-(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static Point operator*(Point a, double factor)
        {
            return new Point(a.X * factor, a.Y * factor);
        }

        public double X { get; set; }

        public double Y { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Point other = obj as Point;
            if ((object)other == null) return false;
            return ((this.X == other.X) && (this.Y == other.Y));
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("{0:F2};{1:F2}", this.X, this.Y);
        }

    }
}