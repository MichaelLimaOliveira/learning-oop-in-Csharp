using System;

namespace Capitulo6.Exemplo.TipoValorTipoReferencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 100;
            p.Y = 200;

            var j = p;

            j.Y = 300;

            PointClass pc = new PointClass();

            pc.X = 100;
            pc.Y = 200;

            var jc = pc;

            jc.Y = 300;

            Console.WriteLine(p);
            Console.WriteLine(j);

            Console.WriteLine();

            Console.WriteLine(pc);
            Console.WriteLine(jc);
        }
    }
}
