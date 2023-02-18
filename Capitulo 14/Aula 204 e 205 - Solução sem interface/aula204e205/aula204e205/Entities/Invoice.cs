using System.Globalization;

namespace aula204e205.Entities
{
    internal class Invoice
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {

            BasicPayment = basicPayment;
            Tax = tax;

        }


        public double TotalPayment { 
        
            get { return BasicPayment + Tax; } 
        
        }

    }
}
