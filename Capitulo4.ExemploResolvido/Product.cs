namespace Capitulo4.ExemploResolvido
{
    internal class Product : object
    {
        public string Name;
        public double Price;
        public int Amount;

        public double TotalValueInStock()
        {
            double total;
            return total = Price * Amount;
        }

        public void AddProduct (int quantity)
        {
            Amount += quantity;
        }

        public void RemoveProduct (int quantitiy)
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
