using System;

namespace Course { 

    class Program
    {
        static void Main(String[] args)
        {

            //Valor máximo 127 e valor mínimo -128.
            /* C# Type */   sbyte a = 100;
            /* .Net Type */ SByte A = 50;

            /* C# Type */   short b = 100;
            /* .Net Type */ Int16 B = 50;

            //Valor máximo é 2.147.483.647
            /* C# Type */ int c = 2147483647;
            /* .Net Type */ Int32 C = 2147483647;

            
            /* C# Type */   long d = 2147483648L;
            /* .Net Type */ Int64 D = 2147483648L;


            //Não aceita número negativo e com valor máximo de 255.
            /* C# Type */   byte e = 126;
            /* .Net Type */ Byte E = 50;

            /* C# Type */   ushort f = 100;
            /* .Net Type */ UInt16 F = 50;

            /* C# Type */   uint g = 100;
            /* .Net Type */ UInt32 G = 50;

            /* C# Type */   ulong h = 100;
            /* .Net Type */ UInt64 H = 50;


            /* C# Type */   float i = 100.05f;
            /* .Net Type */ Single I = 50.05f;


            /* C# Type */   double j = 100.50;
            /* .Net Type */ Double J = 50.50;

            /* C# Type */   decimal k = 100;
            /* .Net Type */ Decimal K = 50;

            //Armazena apenas um caractere e precisa ser colocado entre aspas simples, também é possível inserir o valor UNICODE.
            /* C# Type */   char l = 'l';
            /* .Net Type */ Char L = '\u0041';

            /* C# Type */   bool m = false;
            /* .Net Type */ Boolean M = false;

            //Precisa estar entre aspas duplas. String é imutável, quando você atribui um novo valor para a String, você esta criando uma nova String e não substituindo a anterior.
            /* C# Type */   string n = "String n";
            /* .Net Type */ String N = "String N";


            //Tipo genérico e aceita qualquer coisa.
            /* C# Type */ object o = "Object String"; object oO = 10;



            Console.WriteLine("a " + a);
            Console.WriteLine("A " + A + "\n");

            Console.WriteLine("b " + b);
            Console.WriteLine("B " + B + "\n");

            Console.WriteLine("c " + c);
            Console.WriteLine("C " + C + "\n");

            Console.WriteLine("d " + d);
            Console.WriteLine("D " + D + "\n");

            Console.WriteLine("e " + e);
            Console.WriteLine("E " + E + "\n");

            Console.WriteLine("g " + f);
            Console.WriteLine("F " + F + "\n");

            Console.WriteLine("g " + g);
            Console.WriteLine("G " + G + "\n");

            Console.WriteLine("h " + h);
            Console.WriteLine("H " + H + "\n");

            Console.WriteLine("i " + i);
            Console.WriteLine("I " + I + "\n");

            Console.WriteLine("j " + j);
            Console.WriteLine("J " + J + "\n");

            Console.WriteLine("k " + k);
            Console.WriteLine("K " + K + "\n");

            Console.WriteLine("l " + l);
            Console.WriteLine("L " + L + "\n");

            Console.WriteLine("m " + m);
            Console.WriteLine("M " + M + "\n");

            Console.WriteLine("n " + n);
            Console.WriteLine("N " + N + "\n");

            Console.WriteLine("o " + o);
            Console.WriteLine("oO " + oO + "\n");

        }
    }


}
