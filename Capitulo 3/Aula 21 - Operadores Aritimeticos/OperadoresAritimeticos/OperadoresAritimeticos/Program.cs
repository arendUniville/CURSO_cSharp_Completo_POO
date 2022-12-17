using System;

namespace OperadoresAritimeticos
{

    class Program
    {

        static void Main(string[] args)
        {

            // Primeiramente será feita a multiplicação (4*2) e em seguida a soma com 3.
            int n1 = 3 + 4 * 2;

            // Neste caso, estou priorizando a soma de 3 + 4 e em seguida a multiplicação por 2.
            int n2 = (3 + 4) * 2;

            // Traz o resto da divisão de 17 por 3.
            int n3 = 17 % 3;

            Console.WriteLine("Valor n1: "+n1);
            Console.WriteLine("Valor n2: "+n2);
            Console.WriteLine("Valor n3: "+n3);




            // Caso não houvesse o casting, teríamos o 'problema' de que o compilador entende que o resultado esperado é entre inteiros.
            double n4 = (double)10 / 8;

            // Outra forma de se fazer isso sem precisar colocar o casting no início, é colocando uma casa decimal no próprio número.
            double n44 = 10.0 / 8;

            // Aqui é o resultado se não fizéssemos o casting.
            double n4Error = 10 / 8;

            Console.WriteLine("Valor n4: "+n4);
            Console.WriteLine("Valor n44: "+n44);
            Console.WriteLine("Valor n4Error: "+n4Error);


// -------------------- Baskhara --------------------------------------------

            // Montando valores.
            double a = 1.0, b = -3.0, c = -4.0;

            // Montando expressão aritimética de *--- b² - 4ac ---* da fórmula de Baskhara.
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            // Montando expressão de *--- -b + Sqrt / 2 * a ---*.
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("\r\nResultado delta: "+delta);
            Console.WriteLine("Resultado x1: "+x1);
            Console.WriteLine("Resultado x2: " + x2);
        }
    }
}