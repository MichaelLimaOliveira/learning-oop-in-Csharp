using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.Exercicio.RefOut
{
    internal class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Double(int origin , out int result)
        {
            result = origin * 2;
        }

        public static int Tirar30(int x)
        {
           return x - 30;
        }
    }
}
