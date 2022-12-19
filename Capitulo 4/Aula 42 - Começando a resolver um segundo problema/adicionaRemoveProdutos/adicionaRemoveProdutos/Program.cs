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

            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto: " + p);



        }
    }
}