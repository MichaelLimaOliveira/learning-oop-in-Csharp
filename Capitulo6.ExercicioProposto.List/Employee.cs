using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.ExercicioProposto.List
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public void IncreaseSalary (double percentage)
        {
            Salary += (percentage * Salary / 100);
        }

        public override string ToString()
        {
            return $" {Id}, {Name}, {Salary:F2}";
        }
    }
}
