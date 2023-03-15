namespace teste.codigo
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public Cliente Cliente { get; set; }

        public Telefone(string tipo, string numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

        public Telefone()
        {

        }
    }
}
