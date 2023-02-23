using System;

namespace Aula222
{

    class Program
    {

        static void Main(string[] args)
        {

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";

            //Iniciou valendo este valor:
            cookies["phone"] = "0912302109";

            //Sobrescreveu o valor:
            cookies["phone"] = "2093203801";

        }

    }

}