namespace Capitulo3.Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valueA = int.Parse(Console.ReadLine());
            int valueB = int.Parse(Console.ReadLine());
            int valueC = int.Parse(Console.ReadLine());
            int valueD = int.Parse(Console.ReadLine());

            int difference = (valueA * valueB) - (valueC * valueD);


            Console.WriteLine($"Diferenca = {difference}");
        }
    }
}