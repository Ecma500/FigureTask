using System;
using FigureLibrary.Abstract;
using FigureLibrary.Concrete;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new RightTriangle(7, 4);
            Figure circle = new Circle(5);
            Console.WriteLine($"S прямоугольного треугольника ABC = {triangle.GetArea()}");
            Console.WriteLine($"S окружности = {circle.GetArea()}");
            Console.ReadKey();
        }
    }
}
