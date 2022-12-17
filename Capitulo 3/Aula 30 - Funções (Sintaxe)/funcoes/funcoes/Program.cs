using System;

namespace funcoes
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Digite três números: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());



            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior número é: " + resultado);


        }

        static int Maior(int a, int b, int c) {

            double maior;

            if (a > b && a > c)
            {

                Console.WriteLine("O maior número é: " + a);

            }
            else if (b > c)
            {

                Console.WriteLine("O maior número é: " + b);

            }
            else
            {

                Console.WriteLine("O maior número é: " + c);

            }

        }
    }


}