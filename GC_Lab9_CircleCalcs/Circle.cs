using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab9_CircleCalcs
{
    public class Circle
    {
        private double _radius;

        //Circle constructor that takes a double argument:

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public double GetCircumference() => 2 * Math.PI * _radius;

        public string GetFormattedCircumference() => String.Format("{0:F2}", GetCircumference());

        public double GetArea() => Math.PI * Math.Pow(_radius, 2);

        public string GetFormattedArea() => String.Format("{0:F2}", GetArea());

        private string formatNumber(double x) => Convert.ToString(x);

        public string Format(double x) => formatNumber(x);

        public void PrintArea()
        {
            Console.WriteLine("Area: " + GetFormattedArea());
        }

        public void PrintCircumference()
        {
            Console.WriteLine("Circumference: " + GetFormattedCircumference());
        }
    }
}
