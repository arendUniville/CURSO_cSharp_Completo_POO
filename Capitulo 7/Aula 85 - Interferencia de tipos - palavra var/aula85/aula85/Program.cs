using System;
using System.Globalization;


namespace aula85
{

    class Program
    {

        static void Main(string[] args)
        {

            var x = 10;
            var y = 20.0;
            var z = "30";


            Console.WriteLine(x + " - Tipo: " + x.GetType());
            Console.WriteLine(y.ToString("F1", CultureInfo.InvariantCulture) + " - Tipo: " + y.GetType());
            Console.WriteLine(z + " - Tipo: " + z.GetType());

        }
    }
}