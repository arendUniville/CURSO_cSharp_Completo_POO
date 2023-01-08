using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula68
{
    class Program2
    {

        static void Main(string[] args)
        {

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;


            Console.WriteLine(a);
            Console.WriteLine(b);

        }

    }
}
