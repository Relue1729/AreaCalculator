using System;

namespace AreaCalculatorLibrary.Common
{
    public static class ValidationFunctions
    {
        public static void ThrowOnNegativeDouble(double d, string paramName = default)
        {
            if (d < 0) { throw new ArgumentException($"Параметр {paramName} не может быть отрицательным числом"); }
        }
    }
}