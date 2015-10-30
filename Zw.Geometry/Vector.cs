using System;

namespace Zw.Geometry
{
    /// <summary>
    /// Represents a two-dimensional vector.
    /// </summary>
    public class Vector
    {

        #region Statics -------------------------------------------------------

        private static readonly Vector dirX = new Vector() { X = 1, Y = 0 };
        private static readonly Vector dirY = new Vector() { X = 0, Y = 1 };

        /// <summary>
        /// Vector showing in X+ direction.
        /// </summary>
        public static Vector DirectionX { get { return dirX; } }

        /// <summary>
        /// Vector showing in Y+ direction.
        /// </summary>
        public static Vector DirectionY { get { return dirY; } }

        #endregion

        /// <summary>
        /// X value.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y value.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Angle of vector (in radiant/RAD).
        /// </summary>
        public double Rad
        {
            get { return Math.Atan2(this.Y, this.X); }
        }

        /// <summary>
        /// Angle of vector (in degree/DEG/°).
        /// </summary>
        public double Deg
        {
            get { return Angle.RadToDeg(this.Rad); }
        }

        /// <summary>
        /// Length of vector.
        /// </summary>
        public double Length
        {
            get { return Math.Sqrt((this.X * this.X) + (this.Y * this.Y)); }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Vector()
        {
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="copyFrom"></param>
        public Vector(Vector copyFrom)
        {
            this.X = copyFrom.X;
            this.Y = copyFrom.Y;
        }

        /// <summary>
        /// Creates a normalized vector from a given angle.
        /// </summary>
        /// <param name="angle"></param>
        public Vector(Angle angle)
        {
            this.X = Math.Cos(angle.Radians);
            this.Y = Math.Sin(angle.Radians);
        }

        /// <summary>
        /// Creates a vector between two points.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public Vector(Point p1, Point p2)
        {
            this.X = p2.X - p1.X;
            this.Y = p2.Y - p1.Y;
        }

        /// <summary>
        /// Create a vector with the given lengths.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gives a scaled version of the vector with the given length.
        /// </summary>
        /// <param name="newLength"></param>
        /// <returns></returns>
        public Vector Scale(double newLength)
        {
            double f = newLength / this.Length;
            return new Vector() { X = this.X * f, Y = this.Y * f };
        }

    }
}
