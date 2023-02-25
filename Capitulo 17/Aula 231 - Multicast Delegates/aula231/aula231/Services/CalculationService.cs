using System;

namespace aula231.Services
{
    class CalculationService
    {

        public static double ShowMax(double x, double y) { return (x > y) ? x : y; }

        public static double ShowSum(double x, double y) {  return x * y; }

        public static double Square(double x) { return x * x; }

    }
}
