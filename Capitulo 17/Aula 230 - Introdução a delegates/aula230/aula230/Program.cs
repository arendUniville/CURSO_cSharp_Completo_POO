using aula230.Services;
using System;


namespace aula230
{

    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {

        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            //Forma 1
            BinaryNumericOperation op = CalculationService.Sum;
            
            double result = op(a, b);
            
            Console.WriteLine(result);

            
            //Forma 2
            BinaryNumericOperation opp = new BinaryNumericOperation(CalculationService.Sum);
            
            double resultt = opp(a, b);

            Console.WriteLine(resultt);
            
        }

    }

}