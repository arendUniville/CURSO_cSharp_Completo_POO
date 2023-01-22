using aula138.Entities;
using System;

namespace aula138
{

    class Program
    {

        static void Main(string[] args) 
        {
        
            Account acc1 = new Account(1001, "Matheus", 500.0);

            acc1.Withdraw(50.0);

            Console.WriteLine(acc1.Balance);
        
        }

    }

}