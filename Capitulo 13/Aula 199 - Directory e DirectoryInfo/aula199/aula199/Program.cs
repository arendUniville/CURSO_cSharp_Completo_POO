using System;
using System.IO;
using System.Collections.Generic;


namespace aula199
{

    class Program
    {

        static void Main(string[] args) 
        {

            string path = @"C:\Temp\myFolder";

            try
            {


                /*
                // FORMA 1 
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                // FORMA 2 
                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                */


                //--------------------------Folders

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Folders:");

                foreach (string s in folders)
                {

                    Console.WriteLine(s);

                }

                //--------------------------Files

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files:");

                foreach (string s in files)
                {

                    Console.WriteLine(s);

                }


                Directory.CreateDirectory(path + "\\newFolder");


            }
            catch(IOException e) 
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);

            }

        }

    }

}