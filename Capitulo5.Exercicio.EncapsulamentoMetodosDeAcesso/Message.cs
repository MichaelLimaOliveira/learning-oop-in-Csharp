using System;


namespace Capitulo5.Exercicio.EncapsulamentoMetodosDeAcesso
{
    internal class Message
    {
        //private string TextMessage { get; set; }

        //public string getTextMessage()
        //{
        //    return this.TextMessage;
        //}
        //public void setTextMessage(string value)
        //{
        //    this.TextMessage = value.ToUpper();
        //}

        public void Printer()
        {
            Console.WriteLine(this.TextMessage);
        }

        private string _message;

        public string TextMessage
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value.ToUpper();
            }
        }
    }
}
