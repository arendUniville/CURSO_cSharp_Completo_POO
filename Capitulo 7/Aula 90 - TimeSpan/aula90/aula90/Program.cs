using System;


namespace aula90
{

    class Program
    {

        static void Main(string[] args)
        {


            TimeSpan t1 = new TimeSpan();
            
            //Milisegundos serão transformados em horas.
            TimeSpan t2 = new TimeSpan(900000000L);

            //Hora:Min:Seg
            TimeSpan t3 = new TimeSpan(2, 11, 21);

            //Dia. Hora:Min:Seg
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

            //Dia. Hora:Min:Seg:Milisec
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine();

            //--------------------------------------------------

            TimeSpan tm1 = TimeSpan.FromDays(1.5);
            TimeSpan tm2 = TimeSpan.FromHours(1.5);
            TimeSpan tm3 = TimeSpan.FromMinutes(1.5);
            TimeSpan tm4 = TimeSpan.FromSeconds(1.5);
            TimeSpan tm5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan tm6 = TimeSpan.FromTicks(900000000);

            Console.WriteLine(tm1);
            Console.WriteLine(tm2);
            Console.WriteLine(tm3);
            Console.WriteLine(tm4);
            Console.WriteLine(tm5);
            Console.WriteLine(tm6);





        }
    }

}