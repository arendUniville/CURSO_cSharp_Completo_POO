using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace aula61e62_exercicio
{

    class Program
    {

        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine()); 

            Console.Write("Digite o títular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Você deseja abrir a conta com um depósito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine().ToString().ToLower());
           

            if(resp == 's')
            {

                Console.Write("Digite o valor do depósito inicial: R$");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, depositoInicial);

            }
            else
            {

                conta = new ContaBancaria(numero, titular);

            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);




            Console.WriteLine();
            Console.Write("Digite o valor a ser depositado: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Digite o valor a ser sacado: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);







        }

    }

}