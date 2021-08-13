using AreaCalculatorLibrary.Interfaces;
using AreaCalculatorLibrary.Common;
using System;

namespace AreaCalculatorLibrary.Shapes
{
    public class Circle : IShape
    {
        private double radius;
        public double Radius 
        {
            get => radius;
            set
            {
                ValidationFunctions.ThrowOnNegativeDouble(value, nameof(Radius));
                radius = value;
            }
        }

        public Circle (double radius)
        {
            this.Radius = radius;
        }

        public double GetArea() =>  Math.PI * Math.Pow(Radius, 2);
    }
}