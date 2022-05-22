using System;

namespace Capitulo6.Exemplo.DesalocaçaoDeMemoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("TV", 900.00, 10);
            Product p2 = new Product("SOM", 500.00, 20);



            Console.WriteLine(p1);
            Console.WriteLine(p2);
            // exemplo do garbage collector no momento que o ponteiro de p2 muda o local para onde a referencia de memoria nao existe mais
            p2 = p1;
            Console.WriteLine(p2);

            Console.WriteLine();

            Product p = new Product();
            p.Method2();

            Console.WriteLine(p);
        }
    }
}
