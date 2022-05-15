namespace Capitulo4.Exercicio2.Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new Employee();
            Employee employeeB = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            employeeA.Name = Console.ReadLine();
            Console.Write("Salario: ");
            employeeA.Salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            employeeB.Name = Console.ReadLine();
            Console.Write("Salario: ");
            employeeB.Salary = decimal.Parse(Console.ReadLine());


            Employee average = new Employee();

            Console.WriteLine($"Salario medio = {average.Averege((employeeA.Salary, employeeB.Salary)):F2}");

        }
    }
}