using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zw.Geometry.Tests
{
    [TestClass]
    public class RotationTest
    {
        [TestMethod]
        public void TestRotateAroundOrigin()
        {
            Angle a = new Angle(90, Angle.Representation.Degree);
            Point p1 = new Point(2.5, 0.0);
            var rotated = Rotation.AroundOrigin(a, p1);
            Assert.AreEqual(0.0, rotated.X, 0.01);
            Assert.AreEqual(2.5, rotated.Y, 0.01);
        }

        [TestMethod]
        public void TestRotateAroundPoint()
        {
            Angle a = new Angle(45, Angle.Representation.Degree);
            Point c1 = new Point(0.5, 0.5);
            Point p1 = new Point(1, 2);
            var rotated = Rotation.AroundPoint(c1, a, p1);
            Assert.AreEqual(-0.2071, rotated.X, 0.01);
            Assert.AreEqual(1.9142, rotated.Y, 0.01);
        }
    }
}
