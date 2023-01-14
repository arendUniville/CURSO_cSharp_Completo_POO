using System;
using System.Collections.Generic;


namespace aula78
{

    class Program
    {

        public static void Main(string[] args)
        {
            int quantidadeEmpregados;

            Console.Write("Digite quantos empregados você deseja registrar: ");
            quantidadeEmpregados = int.Parse(Console.ReadLine());


            List<Employee> listEmployees = new List<Employee>();


            for(int i = 1; i <= quantidadeEmpregados; i++)
            {
                var idEmployee = 0;
                string nameEmployee;

                bool isCorrectType;

                Employee newEmployee = new Employee();

                Console.WriteLine("\r\nEmpregado N° " + i);
                
                Console.Write("Digite o ID: ");
                isCorrectType = int.TryParse(Console.ReadLine(), out idEmployee);

                
                if(isCorrectType == false)
                {

                    Console.WriteLine("O valor informado não é um tipo numérico inteiro, favor verifique o valor inserido.");
                    break;

                }

                newEmployee.Id = idEmployee;



                Console.Write("Digite o nome: ");
                newEmployee.Name = Console.ReadLine();


                Console.Write("Digite o salário: ");
                newEmployee.Salary = double.Parse(Console.ReadLine());

                listEmployees.Add(newEmployee);

            }


            Console.WriteLine("\r\nEmpregados(" + listEmployees.Count + "): ");
            

            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine(emp + "\r\n");
            }

            

        }
    }
}