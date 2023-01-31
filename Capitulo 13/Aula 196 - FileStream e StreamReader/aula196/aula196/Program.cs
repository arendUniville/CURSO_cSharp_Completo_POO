using System;
using System.IO;

namespace aula196
{

    class Program
    {

        static void Main(string[] args) 
        {

            string path = @"C:\Temp\file1.txt";

            StreamReader sr = null;

            try
            {

                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }

            }
            catch(IOException e)
            {

                Console.WriteLine("An error occurred: " + e.Message);

            }
            finally
            {

                if(sr != null) sr.Close();

            }

        }

    }

}