using System;


namespace aula92
{

    class Program
    {

        static void Main(string[] args) 
        {

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("\n\n");


            //----------------------------------------------

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine("Days: "+ t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks + "\n\n");

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds + "\n\n");

            //----------------------------------------------Operações

            TimeSpan tt1 = new TimeSpan(1, 30, 10);
            TimeSpan tt2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = tt1.Add(tt2);
            TimeSpan dif = tt1.Subtract(tt2);
            TimeSpan mult = tt2.Multiply(2.0);
            TimeSpan div  = tt2.Divide(2.0);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Dif: " + dif);
            Console.WriteLine("Mult: " + mult);
            Console.WriteLine("Div: " + div);




        }


    }

}