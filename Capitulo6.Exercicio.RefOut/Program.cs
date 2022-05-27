using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.Exercicio.RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int result;
            int c = 60;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            Calculator.Double(b, out result);
            Console.WriteLine(result);

            int tirar = Calculator.Tirar30(c);
            Console.WriteLine(tirar);
        }
    }
}
