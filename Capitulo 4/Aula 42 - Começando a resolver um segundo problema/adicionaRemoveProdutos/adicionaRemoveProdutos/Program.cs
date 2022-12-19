using System;
using System.Globalization;

namespace adicionaRemoveProdutos
{

    class Program
    {

        static void Main(String[] args)
        {

            Produto p = new Produto();
            
            Console.WriteLine("Insira as informações do produto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.Write("\r\nDados do produto: " + p);



        }
    }
}