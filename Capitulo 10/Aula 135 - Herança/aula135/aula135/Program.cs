﻿using System;
using aula135.Entities;

namespace aula135
{

    class Program
    {

        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);


            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);

        }

    }

}