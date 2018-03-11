using System;
using FigureLibrary.Abstract;
using FigureLibrary.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCreateTrinagle()
        {
            double a = 3;
            double b = 4;
            double badSide = 8;

            Figure triangle = new Triangle(a, b, badSide);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCreateRightTrinagle()
        {
            double a = 3;
            double b = 4;
            double badSide = 6;

            Figure triangle = new RightTriangle(a, b, badSide);
        }

        [TestMethod] 
        public void TestGetAreaRightTriangle()
        {
            double a = 3;
            double b = 4;
            double с = 5;

            Figure triangle = new RightTriangle(a, b, с);

            //Расчитываем площадь в ручную по другой формуле
            double s = (a*b)/2;

            Assert.AreEqual(s, triangle.GetArea());

            //Тоже самое для конструктора с катетами
            a = 5;
            b = 7;
            triangle = new RightTriangle(a, b);
            s = (a * b) / 2;
            Assert.AreEqual(s, triangle.GetArea());
        }
    }
}
