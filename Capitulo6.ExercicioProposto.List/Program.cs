using System;
using System.Collections.Generic;

namespace Capitulo6.ExercicioProposto.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int registerNumber = Convert.ToInt32(Console.ReadLine());
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < registerNumber; i++)
            {
                Console.WriteLine($"Employee #{i + 1}: ");
                Console.Write("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                listEmployee.Add(new Employee(id, name, salary));

            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = Convert.ToInt32(Console.ReadLine());


            if (listEmployee.Find(x => x.Id == searchId) != null)
            {
                int id = listEmployee.FindIndex(x => x.Id == searchId);
                Console.Write("Enter the percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());
                listEmployee[id].IncreaseSalary(percentage);
            }
            else
                Console.WriteLine("This id does not exist!");

            Console.WriteLine("Upadate list of employee: ");
            foreach (Employee emp in listEmployee)
            {
                Console.WriteLine(emp.ToString());
            }


        }
    }
}
