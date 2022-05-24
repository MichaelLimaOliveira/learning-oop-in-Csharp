using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.Exercicio.Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos quartos seram alugados? ");
            int quantity = int.Parse(Console.ReadLine());

            Bedroom[] bedrooms = new Bedroom[10];

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                bedrooms[room] = new Bedroom
                {
                    Email = email,
                    Name = name
                };

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < bedrooms.Length; i++)
                if (bedrooms[i]!= null) Console.WriteLine($"{i}: {bedrooms[i].Name}, {bedrooms[i].Email}");
        }
    }
}
