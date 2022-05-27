using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.Exercicio.List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Alex");
            names.Add("Pedro");
            names.Add("Rafa");
            names.Add("Kau");
            names.Add("Pai");
            names.Add("Ana");
            names.Insert(2, "Maicon");

            names.ForEach(e => Console.WriteLine(e));

            string s1 = names.Find(test);
            string s2 = names.Find(x => x[0] == 'R');

            int position1 = names.FindIndex(x => x[0] == 'P');
            int position2 = names.FindLastIndex(x => x[0] == 'P');

            List<string> names2 = names.FindAll(x => x.Length == 3);

            Console.WriteLine();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(position1);
            Console.WriteLine(position2);
            Console.WriteLine();
            names2.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("-----------------------------------------------------");

            names.Remove("Ana");
            names.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("------------------------------------------------------");
            names.RemoveAll(x => x.Length == 3);
            names.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("--------------------------------------------------------");
            names.RemoveRange(1, 2);
            names.ForEach(e => Console.WriteLine(e));


        }

        public static bool test(string x)
        {
            return x[0] == 'K';
        }
    }
}
