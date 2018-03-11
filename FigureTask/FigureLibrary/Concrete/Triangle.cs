using System;
using FigureLibrary.Abstract;

namespace FigureLibrary.Concrete
{
    public class Triangle : Figure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA + sideB < sideC || sideA + sideC < sideB || sideC + sideB < sideA)
                throw new ArgumentException("Не удалось построить треугольник по заданным сторонам");
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double SideA => _sideA;
        public double SideB => _sideB;
        public double SideC => _sideC;

        public override double GetArea()
        {
            //Находим полупериметр
            double p = (_sideA + _sideB + _sideC)/2;

            //Вычисляем по формуле Герона
            return Math.Sqrt(p*(p - SideA)*(p - SideB)*(p - SideC));
        } 
    }
}
