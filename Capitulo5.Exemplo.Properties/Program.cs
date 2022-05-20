using System;

namespace Capitulo5.Exemplo.Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("tV", 10, 500.00);

            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.Amount);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.TotalStockValue().ToString("F2"));


        }
    }
}
