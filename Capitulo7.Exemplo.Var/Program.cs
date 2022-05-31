using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7.Exemplo.Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20.0;
            var z = 30f;
            var v = 50m;
            var c = 'M';
            var b = true;
            var w = "Maria";

            TesteVar teste = new TesteVar();
            teste.Tipo = "E referencia";

            var teste2 = new TesteVar();

            teste2.Tipo = "tbm e referencia";

            var teste3 = teste2;

            Console.WriteLine(teste.Tipo);
            Console.WriteLine(teste2.Tipo);
            Console.WriteLine(teste3.Tipo);

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(z.GetType());
            Console.WriteLine(v.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(w.GetType());


        }
    }
}
