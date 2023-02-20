using aula216.Entities;
using System;


namespace aula216
{

    class Program
    {

        static void Main(string[] args)
        {

            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };


            Console.WriteLine("Validation: ");

            //Valida conteúdo dos objetos.
            Console.WriteLine(a.Equals(b));

            //Valida referência na memória  do objeto.
            Console.WriteLine(a == b);

            Console.WriteLine("\nHash: ");
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine("=============================");

            Client c = new Client { Name = "Jorge", Email = "jorge@gmail.com" };
            Client d = new Client { Name = "Adelaide", Email = "jorge@gmail.com" };

            Console.WriteLine("Validation: ");
            Console.WriteLine(c.Equals(d));
            
            Console.WriteLine(c == d);

            Console.WriteLine("\nHash: ");
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());
        }

    }

}