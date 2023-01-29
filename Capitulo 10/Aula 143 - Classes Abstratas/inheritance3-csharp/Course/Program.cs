using System;
using Course.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Account> list = new List<Account>();


            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            double soma = 0.0;

            foreach(Account account in list)
            {

                soma += account.Balance;

            }

            Console.WriteLine("Total balance: "+ soma.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account account in list)
            {

                account.Withdraw(10.0);

            }


            foreach(Account account in list)
            {

                Console.WriteLine("Updated balance for account: "
                                    + account.Number
                                    + ": "
                                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture)
                                    
                                 );

            }

        }
    }
}
