using System;
using aula226.Extensions;

namespace aula226
{

    class Program
    {

        public static void Main(string[] args)
        {

            DateTime dt = new DateTime(2023, 02, 25, 6, 10, 45);

            Console.WriteLine(dt.ElapsedTime());

        }

    }

}