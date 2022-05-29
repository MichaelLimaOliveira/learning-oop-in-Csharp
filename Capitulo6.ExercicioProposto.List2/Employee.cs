using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.ExercicioProposto.List2
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public int Age { get; private set; }
        public double Salary { get; private set; }

        public Employee(string name, int id, int age, double salary)
        {
            Name = name.ToUpper();
            Id = id;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += (percentage * Salary / 100);
        }

        public override string ToString()
        {
            return $"Name: {Name}\n Id: {Id}\n Age: {Age}\n Salary: {Salary}";
        }


    }
}
