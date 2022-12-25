using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {


            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.GetNome());

            Console.Write("Digite o nome a ser alterado: ");

            string novoNome = Console.ReadLine();

            p.SetNome(novoNome);

            Console.WriteLine(p.GetNome());
            
        }
    }
}