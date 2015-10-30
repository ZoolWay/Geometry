using System;

namespace Zw.Geometry
{
    /// <summary>
    /// Represents a point in 2-dimensional geometry (mutable).
    /// </summary>
    public class Point
    {

        private static Point origin;

        /// <summary>
        /// The coordinate system origin.
        /// </summary>
        public static Point Origin
        {
            get
            {
                return origin ?? (origin = new Point(0, 0));
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Point()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="source"></param>
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

        /// <summary>
        /// X coordinate.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gives the point at the position when going from this one in direction of a given vector.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public Point Go(Vector v)
        {
            return new Point(this.X + v.X, this.Y + v.Y);
        }

        /// <summary>
        /// Gives the point at the position when going from this one in direction of a given vector and the given distance.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public Point Go(Vector v, double distance)
        {
            Vector vDiff = v.Scale(distance);
            return Go(vDiff);
        }

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