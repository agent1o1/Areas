using System;
using Areas.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleInstanceIsCreated()
        {
            var triangle = new Triangle(1, 1, 1);
            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleSidesMustBePositive1()
        {
            var triangle = new Triangle(1, 1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleSidesMustBePositive2()
        {
            var triangle = new Triangle(1, 1, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleMustSatisfyInequality()
        {
            var triangle = new Triangle(1, 1, 100);
        }

        [TestMethod]
        public void RealTriangleTest1()
        {
            var triangle = new Triangle(3, 4, 5);

            var res = triangle.IsRightTriangle();

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void RealTriangleTest2()
        {
            var triangle = new Triangle(8, 7, 9);

            var res = triangle.IsRightTriangle();

            Assert.IsFalse(res);
        }

        [TestMethod]
        public void AreaCalculation()
        {
            var triangle = new Triangle(6, 4, 8);

            var res = triangle.GetArea();

            Assert.AreEqual(Math.Sqrt(135), res);
        }
    }
}
