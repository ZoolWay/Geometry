using System;

namespace Zw.Geometry
{
    public class Angle
    {
        private readonly double angleInRadians;
        private readonly double angleInDegrees;

        public enum Representation
        {
            Radians,
            Degree,
        }

        public Angle(double angle, Representation representation = Representation.Radians)
        {
            switch (representation)
            {
                case Representation.Radians:
                    this.angleInRadians = angle;
                    break;

                case Representation.Degree:
                    this.angleInRadians = angle * Math.PI / 180;
                    break;

                default:
                    throw new NotImplementedException(String.Format("The representation '{0}' is not supported", representation));
            }
            this.angleInDegrees = this.angleInRadians * 180 / Math.PI;
        }

        public double Radians { get { return this.angleInRadians; } }

        public double Degrees { get { return this.angleInDegrees; } }

        public static Angle operator+ (Angle a, Angle b)
        {
            return new Angle(a.angleInRadians + b.angleInRadians);
        }

        public static Angle operator- (Angle a, Angle b)
        {
            return new Angle(a.angleInRadians - b.angleInRadians);
        }

        public static Angle operator- (Angle a)
        {
            return new Angle(-a.angleInRadians);
        }

        public static Angle operator* (Angle a, double multiplicator)
        {
            return new Angle(a.angleInRadians * multiplicator);
        }

        public static implicit operator Angle(double radians)
        {
            return new Angle(radians);
        }

        public override string ToString()
        {
            return String.Format("{0:0.00}°/{1:0.00}r", this.angleInDegrees, this.angleInRadians);
        }

        /// <summary>
        /// Converts an ancle from degree(DEG/°) to radian(RAD).
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        public static double DegToRad(double degree)
        {
            return (Math.PI * degree / 180);
        }

        /// <summary>
        /// Converts an ancle from radian(RAD) to degree(DEG/°).
        /// </summary>
        /// <param name="radian"></param>
        /// <returns></returns>
        public static double RadToDeg(double radian)
        {
            return (radian * 180) / Math.PI;
        }

    }
}
