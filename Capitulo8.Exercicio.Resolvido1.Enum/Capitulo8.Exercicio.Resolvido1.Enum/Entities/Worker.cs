﻿using Capitulo8.Exercicio.Resolvido1.Enum.Entities.Enums;

namespace Capitulo8.Exercicio.Resolvido1.Enum.Entities
{
    class Worker
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; set; }
        public Department Department { get; set; }

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            var sum = BaseSalary;
            foreach (HourContract contract in Contracts) 
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

    }
}
