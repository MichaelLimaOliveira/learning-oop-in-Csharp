using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.Exercicio.List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            List<string> names2 = new List<string> { "Alex", "Maria", "kauanny", "Rafa" };

            names2.RemoveAt(1);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
        }
    }
}
