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

    }
}
