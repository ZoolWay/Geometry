using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zw.Geometry.Tests
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void TestLength()
        {
            Vector v = new Vector(1, 10);
            Assert.AreEqual(10.04987562112089, v.Length);
        }
    }
}
