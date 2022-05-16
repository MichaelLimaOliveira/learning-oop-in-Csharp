namespace Capitulo4.ExercicioDeFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.ChangeName(Console.ReadLine());
            Console.Write("Salário bruto: ");
            employee.ChangeGrossSalary(double.Parse(Console.ReadLine()));
            Console.Write("Imposto: ");
            employee.ChangeTax(double.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine($"Funcionário: {employee.ToString()}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            employee.IncreaseSalary(double.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.Write("Dados atualizados: " + employee.ToString());
            


            
        }
    }
}