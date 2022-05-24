using System;
using System.Linq;

namespace Capitulo6.Exemplo.Vetor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] prod = new Product[n];

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                prod[i] = new Product(name, price);
            }

            double average = prod.Average(p => p.Price);
            Console.WriteLine($"Average price = {average:F2}");


            Console.WriteLine($"{prod[2].Name}, {prod[2].Price:F2}");
        }
    }
}
