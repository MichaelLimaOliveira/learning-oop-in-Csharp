namespace Capitulo4.ExemploResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            product.Name = Console.ReadLine();

            Console.Write("Preco: ");
            product.Price = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            product.Amount = int.Parse(Console.ReadLine());


            Console.WriteLine($"Dados do produto: " + product.ToString());
            //Console.WriteLine(product.TotalValueInStock().ToString("F2"));

            Console.Write("Digite a quantidade a ser adicionada no estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            product.AddProduct(quantity);
            Console.WriteLine("Dados atualizados: " + product.ToString());

            Console.Write("Digite a quantidade a ser removida no estoque: ");
            quantity = int.Parse(Console.ReadLine());
            product.RemoveProduct(quantity);
            Console.WriteLine("Dados atualizados: " + product.ToString());


        }
    }
}