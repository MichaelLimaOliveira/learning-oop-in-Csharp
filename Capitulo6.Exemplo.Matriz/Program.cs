using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.Exemplo.Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            names[0] = "lucas";
            Console.WriteLine(names[0]);

            Array.Resize<string>(ref names, 5);
            Console.WriteLine(names[0]);


            string[,] names2 = new string[5, 5];

            Console.WriteLine(names2.Length);

            Console.WriteLine(names2.Rank);

            Console.WriteLine(names2.GetLength(0));

            Console.WriteLine(names2.GetLength(1));
        }
    }
}
