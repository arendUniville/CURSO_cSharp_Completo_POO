using System;
using System.Globalization;


namespace aula88
{

    class Program
    {

        static void Main(string[] args)
        {

            string original = "abcde FGHIJ ABC abc DEFG    ";

            //Todas as letras para maiúsculo.
            string s1 = original.ToUpper();

            //Todas as letra para minúsculo.
            string s2 = original.ToLower();



            //Remover espaços em branco nos extremos da string.
            string s3 = original.Trim();



            //Encontra a primeira ocorrência que contem a condição mencionada.
            int n1 = original.IndexOf("bc");

            //Encontra a última ocorrência que contem a condição mencionada.
            int n2 = original.LastIndexOf("bc");



            //Corta uma string a partir do índice mencionado.
            string s4 = original.Substring(3);

            //Corta uma string a partir do range mencionado.
            string s5 = original.Substring(3, 5);



            //Substituí um caractere por outro caractere.
            string s6 = original.Replace("a", "x");

            //Substituí uma sequencia de caracteres por outra sequencia de caracteres.
            string s7 = original.Replace("abc", "xy");



            //Verifica se está nulo ou vazio.
            bool b1 = String.IsNullOrEmpty(original);
            
            //Verifica se está nulo ou com espaço em branco.
            bool b2 = String.IsNullOrWhiteSpace(original);





            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("To Upper: -" + s1 + "-");
            Console.WriteLine("To Lower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("Index Of ('bc'): " + n1);
            Console.WriteLine("Last Index Of ('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3,5): " + s5);
            Console.WriteLine("Replace(a,x): -" + s6 + "-");
            Console.WriteLine("Replace(abc,xy): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);


        }
    }

}