using System;
using System.Globalization;


namespace Exercicio2
{
    class Program
    {

        static void Main(String[] args)
        {

            string pessoa = "Matheus";
            int idade = 22;
            char genero = 'M';

            string cifraoReal = "R$";
            double saldo1 = 10.66975;
            double saldo2 = 23.01341;


            //Write e WriteLine com limitação de casas decimais.
            Console.Write(cifraoReal);
            Console.WriteLine(saldo1.ToString("F4"));

            //Write e WriteLine com limitação de casas decimais e formatação americana de numeração.
            Console.Write(cifraoReal);
            Console.WriteLine(saldo2.ToString("F2", CultureInfo.InvariantCulture /* Ignora tabulação do computador e coloca no padrão americano de numeração*/));

            //WriteLine com placeholder¹ e limitador de casas decimais.
            Console.WriteLine("{0} tem {1} anos e está com saldo de {2}{3:F2} na sua conta bancária.", pessoa, idade, cifraoReal, saldo1);

            //WriteLine com placeholder² e limitador de casas decimais.
            Console.WriteLine($"{pessoa} tem {idade} anos e está com saldo de {cifraoReal}{saldo2:F2} na sua conta bancária.");

            //WriteLine com concatenação e limitador de casas decimais.
            Console.WriteLine(pessoa + " tem " + idade + " anos e está com saldo de " + cifraoReal + saldo2.ToString("F2") + " na sua conta bancária.");

        }

    }
}