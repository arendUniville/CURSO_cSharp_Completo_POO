using System;

namespace aula79
{

    class Program
    {

        static void Main(string[] args)
        {

            double[,] mat = new double[2, 3];


            //Traz o total de elementos da matriz criada.
            Console.WriteLine(mat.Length);

            //Traz a quantidade de linhas da matriz criada.
            Console.WriteLine(mat.Rank);


            //Traz a primeira dimensão da matriz criada.
            Console.WriteLine(mat.GetLength(0));

            //Traz a segunda dimensão da matriz criada.
            Console.WriteLine(mat.GetLength(1));
        }
    }
}