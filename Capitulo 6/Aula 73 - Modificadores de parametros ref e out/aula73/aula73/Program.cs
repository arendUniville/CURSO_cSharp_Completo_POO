using System;


namespace aula73
{

    class Program
    {

        static void Main(string[] args)
        {

            //Modificador 'ref' - A variável passada como parametro deve ter sido iniciada.
            int a = 10;
            Calculator.Triple(ref a);

            Console.WriteLine("Modificador 'REF': " + a);


            //Modificador 'out' - A variável passada como parametro não precisa ter sido iniciada.
            int b = 10;
            int triple;

            Calculator.Triple2(b, out triple);

            Console.WriteLine("Modificador 'OUT': " + triple);

        }

    }

}