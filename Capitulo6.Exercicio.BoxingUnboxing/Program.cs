using System;

namespace Capitulo6.Exercicio.BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Object();
            Console.WriteLine(obj.GetHashCode());
            obj = 30;
            Console.WriteLine(obj.GetHashCode());
        }
    }
}
