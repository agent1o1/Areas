using System;
using Areas.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleInstanceIsCreated()
        {
            var circle = new Circle(1);
            Assert.IsNotNull(circle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleRadiusShouldBePositiveNumber1()
        {
            var circle = new Circle(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleRadiusShouldBePositiveNumber2()
        {
            var circle = new Circle(-1);
        }

        [TestMethod]
        public void AreaCalculation()
        {
            var triangle = new Circle(5.5);

            var res = triangle.GetArea();

            Assert.AreEqual(Math.PI * Math.Pow(5.5, 2), res);
        }
    }
}