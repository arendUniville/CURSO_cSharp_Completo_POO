using System;

namespace aula89
{

    class Program
    {

        static void Main(string[] args)
        {
            /*
            DateTime dataTeste = DateTime.Now;

            Console.WriteLine(dataTeste);

            //Formato de como o pc armazena a data.
            Console.WriteLine(dataTeste.Ticks);
            */

            //---------------------------------------------------------

            //Criando um DateTime manualmente.
            DateTime d1 = new DateTime(2018, 11, 25);

            //Criando um DateTime manualmente com segundos.
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);

            
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);




        }
    }

}