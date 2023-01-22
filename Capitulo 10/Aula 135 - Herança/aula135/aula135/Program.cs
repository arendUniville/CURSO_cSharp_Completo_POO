using System;
using aula135.Entities;

namespace aula135
{

    class Program
    {

        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);


            // UpCasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);


            // DownCasting - É uma operação insegura e deve ser usada apenas em casos necessários, depois de ter a validação se o tipo que está vindo realmente é esperado.

                                   // Forçando um tipo.
            BusinessAccount acc4 = (BusinessAccount)acc2;


            // Validando se o tipo vindo é realmente o esperado (Business account).
            if(acc3 is BusinessAccount) 
            {

                // Forma comum de Casting:
                    //BusinessAccount acc5 = (BusinessAccount)acc3;

                // Outra forma de Casting:
                    BusinessAccount acc5 = acc3 as BusinessAccount;

                acc5.Loan(200.0);
                Console.WriteLine("Loan!");

            }


            // Validando se o tipo vindo é realmente o esperado (Savings account).
            if (acc3 is SavingsAccount)
            {

                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();

                Console.WriteLine("Update!");


            }

        }

    }

}