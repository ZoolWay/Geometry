using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zw.Geometry.Tests
{
    [TestClass]
    public class TrigonometryTest
    {
        [TestMethod]
        public void TestDistance()
        {
            Point p1 = new Point(-2, -3);
            Point p2 = new Point(-4, 4);
            double distance = Trigonometry.Distance(p1, p2);
            Assert.AreEqual(7.28, distance, 0.01);
        }

        [TestMethod]
        public void TestSin()
        {
            Angle a = new Angle(90, Angle.Representation.Degree);
            double sin90 = Trigonometry.Sin(a);
            Assert.AreEqual(1, sin90, 0.01);

            Angle b = new Angle(0.5); // radians
            double sin05rad = Trigonometry.Sin(b);
            Assert.AreEqual(0.47942, sin05rad, 0.01);
        }
    }
}
