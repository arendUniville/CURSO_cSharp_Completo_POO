using System;

namespace aula231.Services
{
    class CalculationService
    {

        public static void ShowMax(double x, double y) {
        
            double max = (x > y) ? x : y;
            
            Console.WriteLine(max);
        
        }

        public static void ShowSum(double x, double y) 
        {

            double sum = x + y;
            
            Console.WriteLine(sum);

        }

        public static double Square(double x) { return x * x; }

    }
}
