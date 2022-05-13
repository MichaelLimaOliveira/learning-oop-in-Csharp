namespace Capitulo3.Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valuesA = Console.ReadLine().Split(' ');
            string[] valuesB = Console.ReadLine().Split(' ');
            int peacesA = int.Parse(valuesA[1]);
            int peacesB = int.Parse(valuesB[1]);

            double peaceValueA = double.Parse(valuesA[2]);

            double peaceValueB = double.Parse(valuesB[2]);

            double valueToPay = (peacesA * peaceValueA) + (peacesB * peaceValueB);
            Console.WriteLine($"VALOR A PAGAR: R$ {valueToPay:F2}");
        }
    }
}