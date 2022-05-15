namespace Capitulo4.Exercico1.Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person personA, personB;
            personA = new Person();
            personB = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            personA.Name = Console.ReadLine();

            Console.Write("Idade: ");
            personA.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            personB.Name = Console.ReadLine();

            Console.Write("Idade: "); 
            personB.Age = int.Parse(Console.ReadLine());

            Console.Write("A pessoa mais velha e: ");
            Console.WriteLine(personA.Age > personB.Age ? personA.Name: personB.Name);


        }
    }
}