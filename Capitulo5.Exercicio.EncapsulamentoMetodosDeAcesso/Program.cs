using System;

namespace Capitulo5.Exercicio.EncapsulamentoMetodosDeAcesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message msg1 = new Message();
            msg1.TextMessage = "alo mundo";
            msg1.Printer();
        }
    }
}
