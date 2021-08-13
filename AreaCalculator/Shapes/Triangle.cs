using AreaCalculatorLibrary.Common;
using AreaCalculatorLibrary.Interfaces;
using System;

namespace AreaCalculatorLibrary.Shapes
{
    public class Triangle : IShape
    {
        #region Fields & Properties
        private double a;
        public double A
        {
            get => a;
            set
            {
                ValidationFunctions.ThrowOnNegativeDouble(value, nameof(A));
                a = value;
            }
        }
        private double b;
        public double B
        {
            get => b;
            set
            {
                ValidationFunctions.ThrowOnNegativeDouble(value, nameof(B));
                b = value;
            }
        }
        private double c;
        public double C
        {
            get => c;
            set
            {
                ValidationFunctions.ThrowOnNegativeDouble(value, nameof(C));
                c = value;
            }
        }
        #endregion

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;

            if (!IsValid())
            {
                throw new ArgumentException("Треугольник с заданными сторонами не может существовать");
            }
        }

        public double GetArea()
        {
            var p = (A + B + C) * 0.5; //Половина периметра
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); //Формула Герона
        }

        /// <summary>  Проверяем является ли треугольник прямоугольным </summary>
        public bool IsRight()
        {
            //Сортируем стороны чтобы A всегда была гипотенузой
            if (A < B) { var t = A; A = B; B = t; }
            if (A < C) { var t = A; A = C; C = t; }

            //Теорема Пифагора, true только в случае с прямоугольными треугольниками
            return Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2);
        }

        /// <summary>  Проверяем что треугольник с заданными сторонами может существовать</summary>
        public bool IsValid() => A + B > C && A + C > B && B + C > A;
    }
}