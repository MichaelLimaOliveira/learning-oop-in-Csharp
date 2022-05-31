using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7.Exemplo.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcd";
            Console.WriteLine(original.GetHashCode());

            string original2 = original;
            Console.WriteLine(original2.GetHashCode());
            original = "Maria";
            Console.WriteLine(original.GetHashCode());

            Console.WriteLine(original);
            Console.WriteLine(original2);
        }
    }
}
