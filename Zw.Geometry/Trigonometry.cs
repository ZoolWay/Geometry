using System;

namespace Zw.Geometry
{
    /// <summary>
    /// Provides trigonometric functions which take types of this library as parameters.
    /// </summary>
    public static class Trigonometry
    {

        #region Constants -----------------------------------------------------

        /// <summary>
        /// Constant value of Pi (maps Math.PI).
        /// </summary>
        public const double PI = Math.PI;

        /// <summary>
        /// Constant value of Pi/2.
        /// </summary>
        public const double HALF_PI = PI / 2.0;

        /// <summary>
        /// Constant value of Pi*1.5.
        /// </summary>
        public const double ONEHALF_PI = PI + HALF_PI;

        /// <summary>
        /// Constant value of Pi*2.
        /// </summary>
        public const double TWO_PI = Math.PI * 2;

        #endregion

        /// <summary>
        /// Calculates the sinus of an angle.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double Sin(Angle angle)
        {
            return Sin(angle.Radians);
        }

        /// <summary>
        /// Calculates the sinus of an angle represented in radians (like Math.Sin()).
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static double Sin(double radians)
        {
            return Math.Sin(radians);
        }

        /// <summary>
        /// Calculates the cosinus of an angle.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double Cos(Angle angle)
        {
            return Cos(angle.Radians);
        }

        /// <summary>
        /// Calculates the cosinus of an angle represented in radians (like Math.Cos()).
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static double Cos(double radians)
        {
            return Math.Cos(radians);
        }

        /// <summary>
        /// Calculates the tangens of an angle.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double Tan(Angle angle)
        {
            return Tan(angle.Radians);
        }

        /// <summary>
        /// Caculates the tangens of an angle represented in radians (like Math.Tan()).
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static double Tan(double radians)
        {
            return Math.Tan(radians);
        }

        /// <summary>
        /// Calculates the distance between two points.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Distance(Point a, Point b)
        {
            return Distance(a.X, a.Y, b.X, b.Y);
        }

        /// <summary>
        /// Calculates the distance between two points.
        /// </summary>
        /// <param name="xa"></param>
        /// <param name="ya"></param>
        /// <param name="xb"></param>
        /// <param name="yb"></param>
        /// <returns></returns>
        public static double Distance(double xa, double ya, double xb, double yb)
        {
            return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
        }

        /// <summary>
        /// Calculates the distance between a point and the coordinate origin.
        /// Equals the length of the vector if you see the point as a vector.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Distance(Point a)
        {
            return Distance(Point.Origin, a);
        }

        /// <summary>
        /// Calculates the distance between a point and the coordinate origin.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Distance(double x, double y)
        {
            return Distance(0, 0, x, y);
        }

        /// <summary>
        /// Calculates the length of a circle arc opened by the given angle.
        /// </summary>
        /// <param name="circleRadius"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double GetArcLength(double circleRadius, Angle angle)
        {
            return circleRadius * angle.Radians;
        }

        /// <summary>
        /// Calculates the angle enclosed by the radians drawing the given arc length.
        /// </summary>
        /// <param name="circleRadius"></param>
        /// <param name="arcLength"></param>
        /// <returns></returns>
        public static Angle GetAngleForArcLength(double circleRadius, double arcLength)
        {
            return new Angle(arcLength / circleRadius);
        }

        /// <summary>
        /// Get the coordinates of a point on an arc.
        /// </summary>
        /// <param name="degree">Ancle of the point on the arc in degree (DEG/°)</param>
        /// <param name="arcRadius">Radius of the circle</param>
        /// <param name="arcCenter">Center of the circle/arc (used as offset)</param>
        /// <returns></returns>
        public static Point GetPointOnArc(Angle angle, float arcRadius, Point arcCenter)
        {
            Point p = new Point();
            p.X = Cos(angle) * arcRadius + arcCenter.X;
            p.Y = Sin(angle) * arcRadius + arcCenter.Y;
            return p;
        }

        /// <summary>
        /// Return the point in the middle between two given points.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Point GetMiddle(Point p1, Point p2)
        {
            return new Point(p1.X + ((p2.X - p1.X) / 2), p1.Y + ((p2.Y - p1.Y) / 2));
        }

    }
}
