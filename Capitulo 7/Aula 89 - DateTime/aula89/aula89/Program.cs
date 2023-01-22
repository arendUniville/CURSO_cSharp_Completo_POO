﻿using System;
using System.Globalization;

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


            //---------------------------------------------------------


            DateTime data1 = DateTime.Parse("2000-08-15");
            DateTime data2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime data3 = DateTime.Parse("15/08/2000");
            DateTime data4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine("Data 1: " + data1);
            Console.WriteLine("Data 1: " + data2);
            Console.WriteLine("Data 1: " + data3);
            Console.WriteLine("Data 1: " + data4);


            //---------------------------------------------------------

            DateTime dataFormat1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dataFormat2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(dataFormat1);
            Console.WriteLine(dataFormat2);


        }
    }

}