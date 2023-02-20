﻿using aula206.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula204e205.Services
{
    class BrazilTaxService : ITaxService
    {

        public double Tax(double amount)
        {

            if(amount <= 100)
            {

                return amount * 0.2;

            }
            else
            {

                return amount * 0.15;

            }

        }

    }
}
