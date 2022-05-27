using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.Exercicio.Params
{
    internal class Calculator2
    {
        public static int Calc(int[] vet)
        {
            int sum = 0;
            foreach(int v in vet)
            {
                sum += v;
            }
            return sum;

        }
    }
}
