using System;
using System.Collections.Generic;

namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many employees will be registered? ");
                int quantity = int.Parse(Console.ReadLine());

                List<Employee> list = new List<Employee>();

                for (int i = 0; i < quantity; i++)
                {
                    Console.WriteLine($"\nEmployee #{i + 1}");

                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine());

                    list.Add(new Employee(id, name, salary));
                }

                Console.Write("\nEnter the employee id that will have salary increase: ");
                int idEmployee = int.Parse(Console.ReadLine());

                Employee employee = list.Find(x => x.Id == idEmployee);

                if (employee != null)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine());
                    employee.SalaryIncrease(percentage);
                }
                else
                {
                    Console.WriteLine("This id does not exist!");
                }

                Console.WriteLine("\nUpdate list of employees:");
                foreach (var item in list)
                {
                    Console.WriteLine($"{item}");
                }

                Console.WriteLine("\nPress any key to finish");
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine($"{error.Message}");
                Console.ReadKey();
            }
        }
    }
}
