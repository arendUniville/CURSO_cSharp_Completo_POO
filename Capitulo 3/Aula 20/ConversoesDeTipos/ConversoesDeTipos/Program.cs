using System;


namespace ConversoesDeTipos { 

    class Program
    {

        static void Main(string[] args) {


        // Double para float.
        
            double a;
            float b;

            a = 5.1;
            // Método casting, permitindo que haja perda de informação para que o valor seja inserido na variável de um tamanho menor.
            b = (float)a;

            Console.WriteLine("Resultado A: "+b);


        // Double para int.

            double aA = 5.1;
            int bB = (int)aA;

            Console.WriteLine("Resultado B: "+bB);


        // Dividindo dois int e armazenando em double.

            int theA = 5;
            int theB = 2;

            // Aplico o casting no dividendo, pois é o que importa para o resultado ser correto.
            double resultado = (double)theA / theB;

            Console.WriteLine("Resultado C: "+resultado);

        }
    }


}