using System;
using System.Globalization;

namespace primeiroContatoComPOO
{

    class Program
    {

        static void Main(string[] args)
        {

            Triangulo x, y;
            string maiorArea;

            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Digite as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();


            if (areaX > areaY)
            {

                maiorArea = "X";

            }
            else
            {

                maiorArea = "Y";

            }

            Console.WriteLine("A maior área é: " + maiorArea);



        }
    }
}