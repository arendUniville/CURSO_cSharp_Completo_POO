using System;


namespace aula220
{

    class Program
    {

        public static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {

                    while (!sr.EndOfStream)
                    {

                        string line = sr.ReadLine();
                        Console.WriteLine(line);

                    }

                }

            }catch(IOException e)
            {

                Console.WriteLine(e.Message);

            }

        }

    }

}