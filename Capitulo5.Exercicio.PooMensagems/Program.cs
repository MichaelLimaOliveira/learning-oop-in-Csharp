using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5.Exercicio.PooMensagems
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Message msg1 = new Message("Alo mundo");
            Message msg2 = new Message("Segundo objeto");

            msg1.Print();
            msg2.Print();

            //msg1.Text = "oi"; nao pode pois o set esta protegido linha 11 classe Message
        }
    }
}
