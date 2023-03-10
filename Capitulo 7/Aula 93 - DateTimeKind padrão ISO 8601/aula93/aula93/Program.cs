using System;

namespace aula93 { 


    class Program
    {

        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1 Kind: " + d1.Kind);
            Console.WriteLine("D1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("D1 to Utc: " + d1.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("D2: " + d2);
            Console.WriteLine("D2 Kind: " + d2.Kind);
            Console.WriteLine("D2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("D2 to Utc: " + d2.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("D3: " + d3);
            Console.WriteLine("D3 Kind: " + d3.Kind);
            Console.WriteLine("D3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("D3 to Utc: " + d3.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("-----------------------------------\n");


            //------------------------------------------------------------


            DateTime dd1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dd2 = DateTime.Parse("2000-08-15T13:05:58Z");


            Console.WriteLine("DD1: " + dd1);
            Console.WriteLine("DD1 Kind: " + dd1.Kind);
            Console.WriteLine("DD1 to Local: " + dd1.ToLocalTime());
            Console.WriteLine("DD1 to Utc: " + dd1.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("DD2: " + dd2);
            Console.WriteLine("DD2 Kind: " + dd2.Kind);
            Console.WriteLine("DD2 to Local: " + dd2.ToLocalTime());
            Console.WriteLine("DD2 to Utc: " + dd2.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine(dd2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Cuidado! Está errado
            Console.WriteLine(dd2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // Forma correta


        }

    }

}