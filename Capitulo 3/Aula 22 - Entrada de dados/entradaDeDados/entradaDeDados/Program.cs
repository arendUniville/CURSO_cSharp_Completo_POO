using System;


namespace entradaDeDados
{

    class Program
    {

        static void Main(string[] args)
        {

            // Digita uma frase ou palavra.
            string frase = Console.ReadLine();
            Console.WriteLine(frase);





// ---------------- Separar Por Espaços (Forma step-by-step) -------------------

            // Digita várias palavras de uma única vez, e separa pelos espaços.
            string s = Console.ReadLine();

            // Cria um vetor que pega a frase escrita na variável 's' e atribuí a um índice a cada vez que existir um espaço.
            string[] vet = s.Split(' ');

            // Atribuí cada índice do vetor que foi criado a uma variável.
            string s1 = vet[0];
            string s2 = vet[1];
            string s3 = vet[2];

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);



// ---------------- Separar Por Espaços (Forma dinâmica) -------------------

            string[] g = Console.ReadLine().Split(' ');

            string g1 = g[0];
            string g2 = g[1];
            string g3 = g[2];


            Console.WriteLine(g1);
            Console.WriteLine(g2);
            Console.WriteLine(g3);

        }

    }

}