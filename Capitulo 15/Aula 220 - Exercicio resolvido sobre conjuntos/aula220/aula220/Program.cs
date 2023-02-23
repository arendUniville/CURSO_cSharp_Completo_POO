﻿using System;
using aula220.Entities;

namespace aula220
{

    class Program
    {

        public static void Main(string[] args)
        {

            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {

                    while (!sr.EndOfStream)
                    {

                        string[] line = sr.ReadLine().Split(' ');

                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { Username = name, Instant = instant });


                    }


                    Console.WriteLine("Total users: " + set.Count);

                }

            }catch(IOException e)
            {

                Console.WriteLine(e.Message);

            }

        }

    }

}