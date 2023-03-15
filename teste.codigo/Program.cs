using teste.codigo.Infra;

namespace teste.codigo
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool verdade = true;
            bool mentira = false;

            bool resultado = verdade | Program.BomDia();
            Console.WriteLine($"o resultado 1 e : {resultado}");
            bool resultado2 = mentira | Program.BomDia();
            Console.WriteLine($"o resultado 2 e : {resultado2}");


            bool resultado3 = verdade || Program.BomDia();
            Console.WriteLine($"o resultado 3 e : {resultado3}");
            bool resultado4 = mentira & Program.BomDia();
            Console.WriteLine($"o resultado 4 e : {resultado4}");

            using (var comercioContext = new ComercioContext())
            {
                var estevao = comercioContext.Clientes.Where(e => e.ID == 1).FirstOrDefault();
                estevao.UpdateSobrenone("Alves");
                comercioContext.SaveChanges();
            }
           

            //var cliente = new Cliente("Estrevim", 'F', "estrevim@gmail.com", "14615080611", "Alves");

            //var telefone1 = new Telefone("Celular", "31983696953");
            //var telefone2 = new Telefone("Fixo", "34765344");

            //cliente.AddTelefone(telefone1);
            //cliente.AddTelefone(telefone2);

            //var endereco = new Endereco("Av Henfil", "Serrano", "Belo Horizonte", "MG");

            //cliente.SetEndereco(endereco);

            //using(var comercioContext = new ComercioContext())
            //{
            //    comercioContext.Clientes.Add(cliente);
            //    comercioContext.SaveChanges();
            //}
        }

        static bool BomDia()
        {
            Console.WriteLine("Bom Dia!");
            return true;
        }
    }
}