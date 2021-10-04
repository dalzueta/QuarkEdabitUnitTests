using System;
using System.Collections.Generic;
using System.Text;

namespace Quark.Edabit.Exercises
{
    public class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
