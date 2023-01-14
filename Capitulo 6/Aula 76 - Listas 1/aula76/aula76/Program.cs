using System;
using System.Collections.Generic;

namespace aula76
{

    class Program
    {

        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            List<string> listIncrementManually = new List<string> {"Maria", "Alex", "Box"};

            //LIST------------------------------------------------------------------------------------------------------------------------

                list.Add("Maria");
                list.Add("Alex");
                list.Add("Bob");
                list.Add("Anna");
                list.Add("Joaquino");
                list.Add("Almeida");
                list.Add("Bonifácio");
                list.Add("Mendes");

                list.Insert(2, "Marco");


                foreach(string s in list)
                {

                    Console.WriteLine(s);
                }


                //Realiza a contagem dos elementos da lista.
                Console.WriteLine("\r\nList count elements: " + list.Count);



                //Trazer o primeiro elemento que inicia com a letra 'A' através de uma expressão lambda.
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("First A: " + s1);

                //Trazer o último elemento que inicia com a letra 'A' através de uma expressão lambda.
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Last A: " + s2);



                //Trazer a posição do primeiro elemento que inicia com a letra 'A' através de uma expressão lambda.
                int pos1 = list.FindIndex(x => x[0] == 'A');
                Console.WriteLine("First position 'A': " + pos1);

                //Trazer a posição do último elemento que inicia com a letra 'A' através de uma expressão lambda.
                int pos2 = list.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Last position 'A': " + pos2);

                Console.WriteLine("===================================\r\n");


            //FILTER LIST------------------------------------------------------------------------------------------------------------------------


                //Criar uma nova lista com a condição desejada através de lambda.
                List<string> list2 = list.FindAll(x => x.Length == 5);


                Console.WriteLine("Elementos da lista que possuem apenas 5 caracteres: ");

                foreach(string obj in list2)
                {

                    Console.WriteLine(obj);

                }

                Console.WriteLine("===================================\r\n");


            //REMOVE LIST------------------------------------------------------------------------------------------------------------------------

                //Remover um elemento a partir de uma string.
                list.Remove("Alex");

                Console.WriteLine("Lista com o Alex removido: ");

                foreach (string s in list)
                    {

                        Console.WriteLine(s);
                    }


                //Remover todos os elementos da lista respeitando a condição inserida através de lambda.
                list.RemoveAll(x => x[0] == 'M');


                Console.WriteLine("\r\nLista com os itens que não posseum 'M' no início da palavra: ");

                foreach (string s in list)
                    {

                        Console.WriteLine(s);
                    }


                //Remover um elemento a partir de uma string.
                list.RemoveAt(1);


                Console.WriteLine("\r\nLista após a removação do elemento 1: ");

                foreach (string s in list)
                    {

                        Console.WriteLine(s);
                    }



                //Remover elementos a partir de uma faixa de valores.


        }
    }
}