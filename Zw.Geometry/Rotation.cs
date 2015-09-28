using System;
using static Zw.Geometry.Trigonometry;

namespace Zw.Geometry
{
    public static class Rotation
    {
        public static Point AroundPoint(Point rotationCenter, Angle angle, Point pointToRotate)
        {

            // translate to origin
            Point rp = new Point(pointToRotate.X - rotationCenter.X, pointToRotate.Y - rotationCenter.Y);

            // rotate
            Point rotated = AroundOrigin(angle, rp);

            // translate back
            return new Point(rotated.X + rotationCenter.X, rotated.Y + rotationCenter.Y);
        }

        public static Point AroundOrigin(Angle angle, Point pointToRotate)
        {
            double s = Sin(angle);
            double c = Cos(angle);

            double xnew = pointToRotate.X * c - pointToRotate.Y * s;
            double ynew = pointToRotate.X * s + pointToRotate.Y * c;

            return new Point(xnew, ynew);
        }
    }
}
