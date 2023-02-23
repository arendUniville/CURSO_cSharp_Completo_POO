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

            cookies.Remove("email");


            if (cookies.ContainsKey("email"))
            {

                Console.WriteLine(cookies["email"]);

            }
            else
            {

                Console.WriteLine("There is no 'email' key");
            
            }


            Console.WriteLine("Size: " + cookies.Count);



            Console.WriteLine("All cookies: ");
            foreach(KeyValuePair<string, string> item in cookies)
            {

                Console.WriteLine(item.Key + ": " + item.Value);

            }

        }

    }

}