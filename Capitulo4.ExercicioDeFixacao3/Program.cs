namespace Capitulo4.ExercicioDeFixacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.ChangeName(Console.ReadLine());

            Console.WriteLine("Digite as três notas do aluno: ");
            student.ChangeFirstTrimester(double.Parse(Console.ReadLine()));
            student.ChangeSecondTrimester(double.Parse(Console.ReadLine()));
            student.ChangeThirdTrimester(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Nora final = {student.FinalGrade():F2}");
            student.Result();
        }
    }
}