using System.Globalization;

namespace Capitulo4.Exemplos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com as medidas do triangulo x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entr com as medidas do trinagulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX, areaY, p;

            areaX = x.Area();
            Console.WriteLine($"A area de x = {areaX:F4}");

            areaY = y.Area();
            Console.WriteLine($"A area de y = {areaY:F4}");
            var max = "";
            max = areaX > areaY ? "X" : "Y";
            Console.WriteLine($"A mairo area e de : {max}");

        }
    }
}