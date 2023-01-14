using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aula78
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employee() { }

        public Employee(int id, string name, double salary)
        {

            Id = id;
            Name = name;
            Salary = salary;

        }


        public void increaseSalary(double increase)
        {

            double addMarge = Salary * increase;

            Salary += addMarge;

        }


        public override string ToString()
        {
            return "Id: " + Id + "\r\nNome: " + Name + "\r\nSalário: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
