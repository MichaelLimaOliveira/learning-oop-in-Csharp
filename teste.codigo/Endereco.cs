using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.codigo
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairros { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Cliente Cliente { get; set; }
        public int Id_Cliente { get; set; }

        public Endereco(string rua, string bairros, string cidade, string estado)
        {
            Rua = rua;
            Bairros = bairros;
            Cidade = cidade;
            Estado = estado;
        }

        public Endereco()
        {

        }
    }
}
