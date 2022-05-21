using System;

namespace Capitulo6.Exemplo.TipoValorTipoReferencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = new TaggedInteger(0);
            n1.AddTag("A");
            Console.WriteLine(n1);  // output: 0 [A]

            var n2 = n1;
            n2.Number = 7;
            n2.AddTag("B");

            var n3 = new TaggedInteger(2);
            n3.AddTag("C");

            Console.WriteLine(n1);  // output: 0 [A, B]
            Console.WriteLine(n2);  // output: 7 [A, B]
            Console.WriteLine(n3);  // output: 2 [C]
        }
    }
}
