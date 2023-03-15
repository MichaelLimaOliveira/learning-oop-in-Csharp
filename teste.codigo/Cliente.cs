using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.codigo
{
    public class Cliente
    {
        public int ID { get; protected set; }
        public string Nome { get; protected set; }
        public char Sexo { get; protected set; }
        public string Email { get; protected set; }
        public string Cpf { get; protected set; }
        public List<Telefone> Telefones { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public string Sobrenome { get; protected set; }

        public Cliente(string nome, char sexo, string email, string cpf, string sobrenome)
        {
            Nome = nome;
            Sexo = sexo;
            Email = email;
            Cpf = cpf;
            Telefones = new List<Telefone>();
            Sobrenome = sobrenome;
        }

        public Cliente()
        {

        }

        public void AddTelefone(Telefone telefone)
        {
            if (telefone is null)
                throw new Exception("Telefone não pode ser nulo!");

            Telefones.Add(telefone);
        }

        public void SetEndereco(Endereco endereco)
        {
            if (endereco is null)
                throw new Exception("Endereco não pode ser nulo!");

            Endereco = endereco;
        }

        public void UpdateSobrenone(string sobrenome)
        {
            Sobrenome = sobrenome;
        }
    }
}
