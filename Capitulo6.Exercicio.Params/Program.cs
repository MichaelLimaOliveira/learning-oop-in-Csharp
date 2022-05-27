using System;

namespace Capitulo6.Exercicio.Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora 1");
            Console.WriteLine(Calculator1.Calc1(4, 3));
            Console.WriteLine(Calculator1.Calc2(4, 3, 2));
            Console.WriteLine(Calculator1.Calc3(4, 3, 2, 1));

            Console.WriteLine("Calculadora 2");
            Console.WriteLine(Calculator2.Calc(new int[] { 4, 3 }));
            Console.WriteLine(Calculator2.Calc(new int[] { 4, 3, 2 }));
            Console.WriteLine(Calculator2.Calc(new int[] { 4, 3, 2, 1 }));

            Console.WriteLine("Calculadora 3");
            Console.WriteLine(Calculator3.Calc(4, 3));
            Console.WriteLine(Calculator3.Calc(4, 3, 2));
            Console.WriteLine(Calculator3.Calc(4, 3, 2, 1));
        }
    }
}
