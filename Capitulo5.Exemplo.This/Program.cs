using System;

namespace Capitulo5.Exemplo.This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product geladeira = new Product("Geladeira primor", 1200.00m, "0001", 50);

            Console.WriteLine(geladeira.ToString());


        }
    }
}
