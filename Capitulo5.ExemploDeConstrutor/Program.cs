namespace Capitulo5.ExemploDeConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preco: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            int amount = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, amount);
            //Product product1 = new Product(name, price); valido pois tem o contrutor de 2 argumentos
            //Product product2 = new Product(); valido pois tbm tem o construtor vazio

            //metodo alternativo para criar um construtor para uma class
            Product productA = new Product()
            {
                Name = name,
                Price = price,
                Amount = amount
            };

            Console.WriteLine($"Dados do produto: " + product.ToString());

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