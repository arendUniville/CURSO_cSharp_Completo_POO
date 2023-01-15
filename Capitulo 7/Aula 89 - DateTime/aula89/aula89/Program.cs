using System;

namespace aula89
{

    class Program
    {

        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            long numeroMaisAleatorioPossivel = (d1.Ticks * 3) / 233333333666999;

            Console.WriteLine(numeroMaisAleatorioPossivel);

        }
    }

}