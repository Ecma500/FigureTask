using System;
using System.CodeDom;

namespace FigureLibrary.Concrete
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double catetA, double catetB) : base(catetA, catetB, Math.Sqrt(Math.Pow(catetA, 2) + Math.Pow(catetB, 2)))
        {
        }

        public RightTriangle(double catetA, double catetB, double hypotenuse) : base(catetA, catetB, hypotenuse)
        {
            if((Math.Pow(catetA, 2) + Math.Pow(catetB, 2)) != Math.Pow(hypotenuse, 2))
                throw new ArgumentException("Не удалось построить прямоугольный треугольник по заданным сторонам");   
        } 
    }
}
