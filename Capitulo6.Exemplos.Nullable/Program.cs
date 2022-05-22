using System;

namespace Capitulo6.Exemplos.Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = null; da erro
            //string x = null; //passa 

            //Nullable<double> x = null; a form,a simplificada abaixo

            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X Nao tem valor atribuido");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y Nao tem valor atribuido");

            double z = x ?? 4.0;// se x tiver valor z recebe x se nao z recebe o valor depois do "??"

        }
    }
}
