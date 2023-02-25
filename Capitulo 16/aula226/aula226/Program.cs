using System;

namespace aula226
{

    class Program
    {

        public static void Main(string[] args)
        {


            Console.Write("Extensão de método no formato DateTime: ");
            DateTime dt = new DateTime(2023, 02, 25, 6, 10, 45);

            Console.WriteLine(dt.ElapsedTime());


            Console.WriteLine("\n------------------------------------------");
            Console.Write("\nExtensão de método no formato String: ");

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

        }

    }

}