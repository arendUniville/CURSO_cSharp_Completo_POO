using System;


namespace aula91
{


    class Program
    {

        static void Main(string[] args)
        {

            DateTime i = new DateTime(2001, 8, 15, 13, 34, 58, 275);


            Console.WriteLine(i);
            Console.WriteLine("1) Date: " + i.Date);
            Console.WriteLine("2) Day: " + i.Day);
            Console.WriteLine("3) DayOfWeek: " + i.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + i.DayOfYear);
            Console.WriteLine("5) Hour: " + i.Hour);
            Console.WriteLine("6) Kind: " + i.Kind);
            Console.WriteLine("7) Millisecond: " + i.Millisecond);
            Console.WriteLine("8) Minute: " + i.Minute);
            Console.WriteLine("9) Month: " + i.Month);
            Console.WriteLine("10) Second: " + i.Second);
            Console.WriteLine("11) Ticks: " + i.Ticks);
            Console.WriteLine("12) TimeOfDay: " + i.TimeOfDay);
            Console.WriteLine("13) Year: " + i.Year + "\n\n\n\n");


            //---------------------------------------------------------------------


            DateTime d = new DateTime(2001, 8, 15, 13, 34, 58);


            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());

            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\n\n\n");


            //---------------------------------------------------------------------

            DateTime h = new DateTime(2001, 8, 15, 13, 34, 58);

            // Adicionando 2 horas.
            DateTime h2 = h.AddHours(2);
            h2 = h2.AddMinutes(5);


            Console.WriteLine(h);
            Console.WriteLine(h2 + "\n\n\n");

            //---------------------------------------------------------------------

            DateTime j1 = new DateTime(2000, 10, 15);
            DateTime j2 = new DateTime(2000, 10, 18);

            TimeSpan t = j2.Subtract(j1);

            Console.WriteLine(t);




        }

    }

}