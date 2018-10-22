using System;
using Areas.Concrete;
using Areas.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CommonTests
    {
        //Надеюсь вы это имели ввиду под "Вычисление площади фигуры без знания типа фигуры", нужно более понятное описание данного функционала
        [TestMethod]
        public void PossibleToGetAreaEvenIfExactTypeOfFigureIsUnknown1()
        {
            IFigure figure = new Triangle(3,4,5);

            var res = figure.GetArea();

            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void PossibleToGetAreaEvenIfExactTypeOfFigureIsUnknown2()
        {
            IFigure figure = new Circle(3);

            var res = figure.GetArea();

            Assert.AreEqual(Math.PI * Math.Pow(3,2), res);
        }
    }
}