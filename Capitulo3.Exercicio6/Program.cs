namespace Capitulo3.Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double[] values = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            // a = 0,  b = 1, c = 2, d = 3
            double areaTriangle = (values[0] * values[2]) / 2;
            double areaCircle = pi * Math.Pow(values[2], 2);
            double areaTrapeze = ((values[0] + values[1]) * values[2]) / 2;
            double areaSquare = values[1] * values[1];
            double areaRectangle = values[0] * values[1];

            Console.WriteLine(areaTriangle.ToString("F3"));
            Console.WriteLine(areaCircle.ToString("F3"));
            Console.WriteLine(areaTrapeze.ToString("F3"));
            Console.WriteLine(areaSquare.ToString("F3"));  
            Console.WriteLine(areaRectangle.ToString("F3"));

        }
    }
}