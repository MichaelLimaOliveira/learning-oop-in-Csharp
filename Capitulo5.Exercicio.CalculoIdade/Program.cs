using System;


namespace Capitulo5.Exercicio.CalculoIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            Console.WriteLine("Programa que calcula a idade de uma pessoa");
            
            Console.Write("Nome da pessoa: ");
            p1.Name = Console.ReadLine();

            Console.Write("Ano de nascimento: ");
            p1.YearOfBirth = Convert.ToInt32(Console.ReadLine());

            p1.PrintDate();
        }
    }
}
