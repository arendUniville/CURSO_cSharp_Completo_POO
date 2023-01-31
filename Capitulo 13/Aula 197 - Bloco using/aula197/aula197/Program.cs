using System;
using System.IO;


namespace aula197
{

    class Program
    {

        static void Main(string[] args)
        {

            string path = @"C:\Temp\file1.txt";

            //Method one
            try
            {
                /*
                
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {

                    using (StreamReader sr = new StreamReader(fs))
                    {

                        while (!sr.EndOfStream)
                        {

                            string line = sr.ReadLine();
                            Console.WriteLine(line);

                        }

                    }

                }

                */

            }
            catch (IOException e)
            {
                /*
                Console.WriteLine(e.Message);
                */
            }


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


            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }



        }

    }

}