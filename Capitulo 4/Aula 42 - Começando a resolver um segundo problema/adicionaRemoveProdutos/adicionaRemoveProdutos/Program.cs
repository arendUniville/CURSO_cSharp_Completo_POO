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


            Console.Write("\r\n\r\nDigite o número de produtos a serem adicionados: ");
            int qnt = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qnt);

            Console.WriteLine("Dados atualizados: " + p);


            Console.Write("\r\n\r\nDigite o número de produtos a serem removidos: ");
            qnt = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qnt);

            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}