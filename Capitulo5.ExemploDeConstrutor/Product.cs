namespace Capitulo5.ExemploDeConstrutor
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        //permite um contrutor vazio
        public Product()
        {

        }
        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }
        // sobrecarga
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            //Amount = 0; Opcional pois por padaro no c# campos de valores numericos vazios recebem 0 .
        }
        public double TotalValueInStock()
        {
            double total;
            return total = Price * Amount;
        }

        public void AddProduct(int quantity)
        {
            Amount += quantity;
        }

        public void RemoveProduct(int quantitiy)
        {
            Amount -= quantitiy;
        }

        public override string ToString()
        {
            return Name + ", $ "
                        + Price.ToString("F2")
                        + ", "
                        + Amount
                        + " unidade, Total: $ "
                        + TotalValueInStock().ToString("F2");
        }
    }
}
