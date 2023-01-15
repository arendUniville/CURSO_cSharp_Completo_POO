using System;
using System.Collections.Generic;


namespace aula78
{

    class Program
    {

        public static void Main(string[] args)
        {

            int quantidadeEmpregados;
            var idEmployee = 0;
            var salary = 0.0;   
            string nameEmployee;
            bool isCorrectType;
            int idEmployeeToIncrease;
            double marginToIncrease;

            
            
//------Registrando empregados:

            Console.Write("Digite quantos empregados você deseja registrar: ");
            quantidadeEmpregados = int.Parse(Console.ReadLine());


            List<Employee> listEmployees = new List<Employee>();


            for(int i = 1; i <= quantidadeEmpregados; i++)
            {

                Employee newEmployee = new Employee();

                Console.WriteLine("\r\nEmpregado N° " + i);
                
                Console.Write("Digite o ID: ");
                isCorrectType = int.TryParse(Console.ReadLine(), out idEmployee);

                
                if(isCorrectType == false)
                {

                    Console.WriteLine("O valor informado não é um tipo numérico inteiro, favor verifique o valor inserido.");
                    return;

                }

                newEmployee.Id = idEmployee;



                Console.Write("Digite o nome: ");
                newEmployee.Name = Console.ReadLine();


                Console.Write("Digite o salário: ");
                isCorrectType = double.TryParse(Console.ReadLine(), out salary);

                if (isCorrectType == false)
                {

                    Console.WriteLine("O valor informado não é um tipo numérico decimal, favor verifique o valor inserido.");
                    return;

                }

                newEmployee.Salary = salary;

                listEmployees.Add(newEmployee);

            }



//------Mostrando lista de empregados:

            Console.WriteLine("\r\nEmpregados(" + listEmployees.Count + "): ");
            

            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine(emp + "\r\n");
            }



//------Realizar aumento:

            Console.Write("Insira o ID do usuário que receberá o aumento: ");
            isCorrectType = int.TryParse(Console.ReadLine(), out idEmployeeToIncrease);


            if (isCorrectType == false)
            {

                Console.WriteLine("O valor informado não é um tipo numérico inteiro, favor verifique o valor inserido.");
                return;

            }

            Console.Write("Insira a margem de aumento: ");
            isCorrectType = double.TryParse(Console.ReadLine(), out marginToIncrease);

            if (isCorrectType == false)
            {

                Console.WriteLine("O valor informado não é um tipo numérico decimal, favor verifique o valor inserido.");
                return;
                
            }


            







        }
    }
}