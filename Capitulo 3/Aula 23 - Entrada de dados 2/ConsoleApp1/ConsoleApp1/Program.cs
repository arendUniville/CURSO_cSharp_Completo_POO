using System;
using System.Net.Http.Headers;
using System.Globalization;

namespace entradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine()); 
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine("\r\nInt digitado: "+n1);
            Console.WriteLine("Tipo do valor: " + n1.GetType());

            Console.WriteLine("\r\nChar digitado: "+ch);
            Console.WriteLine("Tipo do valor: "+ch.GetType());

            Console.WriteLine("\r\nDouble digitado: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Tipo do valor: " + n2.GetType());

            Console.WriteLine("\r\nO nome informado é: " + nome + "\r\nO sexo informado é: " + sexo);
            Console.WriteLine("A idade informada é: " + idade + "\r\nA altura informada é: " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }

}