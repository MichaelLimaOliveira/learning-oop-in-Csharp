namespace Capitulo4.Exemplo.Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de raio: ");
            double radius = double.Parse(Console.ReadLine());
            

            double circ = Calculator.Circumference(radius);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));

            double volume = Calculator.Volume(radius);

            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"Valor de PI: {Calculator.Pi:F2}");

        }
    }
}