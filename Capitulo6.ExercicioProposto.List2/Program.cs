using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.ExercicioProposto.List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ContractEmployee = new List<Employee>();
            Console.Write("How many contracts todays? ");
            int contractNumbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contractNumbers; i++)
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                ContractEmployee.Add(new Employee(name, id, age, salary));
            }

            ContractEmployee.Insert(2, new Employee("Augusto Kaique", 322, 28, 4800.00));

            Console.WriteLine("Contract List: ");

            foreach (Employee emp in ContractEmployee) Console.WriteLine(emp.ToString());

            Console.Write("Enter de global increase: ");
            double increaseValue = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < ContractEmployee.Count; i++)
                if (ContractEmployee[i] != null) 
                    ContractEmployee[i].IncreaseSalary(increaseValue);

            Console.WriteLine("New Contract list: ");

            foreach (Employee emp in ContractEmployee) 
                Console.WriteLine(emp.ToString());

            for (int i = 0; i < ContractEmployee.Count; i++)
            {

            }
        }
    }
}
