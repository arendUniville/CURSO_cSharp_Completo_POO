﻿using System;


namespace aula66
{


    class Program
    {

        static void Main(string[] args) 
        {

            Point p;

            p.X = 10;
            p.Y = 20;   

            Console.WriteLine(p);


            p = new Point();

            Console.WriteLine(p);

        }

    }

}