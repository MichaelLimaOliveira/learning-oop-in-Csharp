using Capitulo8.Exercicio.Resolvido1.Enum.Entities;
using Capitulo8.Exercicio.Resolvido1.Enum.Entities.Enums;
using System.Globalization;

Console.Write("Enter departament's name: ");
string departmentName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
var name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
var baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

var department = new Department(name: departmentName);
var worker = new Worker(name: name, level: level, baseSalary: baseSalary, department: department);

Console.Write("How many contracts to this worker? ");
var quantityContracts = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantityContracts; i++)
{
    Console.WriteLine($"Enter {i} contract data: ");
    Console.Write("Data (DD/MM/YYYY): ");
    var date = DateTime.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    var valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    int hours = int.Parse(Console.ReadLine());
    var contract = new HourContract(date: date, valuePerHour: valuePerHour, hours: hours);
    worker.AddContract(contract: contract);
}

Console.WriteLine();
Console.Write("Enter month and year to calculete income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year: year, month: month));


