using System;

namespace estruturaRepeticaoFor
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Quantos números INTEIROS você deseja digitar? ");

            int quantNumeros = int.Parse(Console.ReadLine());


            int soma = 0;

            for(int i = 1; i <= quantNumeros; i++)
            {
                
                Console.Write("Valor: #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());

                soma += valor;

            }

            Console.WriteLine("Soma é = "+soma);

        }
    }

}