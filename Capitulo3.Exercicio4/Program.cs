namespace Capitulo3.Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idEmployee = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());
            double salaryHour = double.Parse(Console.ReadLine());

            double salary = salaryHour * hoursWork;

            Console.WriteLine($"Number = {idEmployee}");
            Console.WriteLine($"Salary = U$ {salary:F2}");

        }
    }
}