using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5.Exercicio.PooMensagems
{
    internal class Message
    {
        public string Text { get; protected set; }

        public Message(string text)
        {
            Text = text;
        }

        public void Print()
        {
            Console.WriteLine(Text);
        }
    }
}
