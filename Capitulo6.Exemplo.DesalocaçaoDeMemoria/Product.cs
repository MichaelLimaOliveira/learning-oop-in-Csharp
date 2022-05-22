namespace Capitulo6.Exemplo.DesalocaçaoDeMemoria
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Product()
        {

        }

        public Product(string name, double price, int amount) => (Name,Price,Amount) = (name,price,amount);

        public override string ToString()
        {
            return $"Name: {Name}, Preço: $ {Price}, Quantidade: {Amount}";
        }

        public void Method1()
        {
            int x = 10;
            if (x > 0)
            {
                // a partir do momento que o programa sair do scopo do if a variavel y sera deletada este e um exemplo de desalocaçao por escopo
                int y = 30;
            }
            System.Console.WriteLine(x);
            // e assim que o metodo terminar sua açao a variavel x tbm sumira da memoria
        }

        public Product Method2()
        {
            // vai passar seu ponteiro atual para quem o chamou e sua referencia stack vai sumir deixando seu valor no heap para a nova referencia na stak que a chamou
            Product prod = new Product("TV", 900.0, 0);
            return prod;
            // tbm e um exemplo de desalocaçao por scopo
        }
    }
}
