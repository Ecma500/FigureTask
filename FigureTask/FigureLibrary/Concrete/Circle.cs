using System;
using FigureLibrary.Abstract;

namespace FigureLibrary.Concrete
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Radius => _radius;
        public double Diametr => 2*_radius;

        public override double GetArea() => Math.PI * Math.Pow(_radius, 2);
    }
}
