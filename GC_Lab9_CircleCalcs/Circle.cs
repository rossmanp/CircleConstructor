using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab9_CircleCalcs
{
    class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public double GetCircumference() => 2 * Math.PI * _radius;

        public string GetFormattedCircumference() => String.Format("{0:F2}", GetCircumference());

        public double GetArea() => Math.PI * Math.Pow(_radius, 2);

        public string GetFormattedArea() => String.Format("{0:F2}", GetArea());


    }
}
