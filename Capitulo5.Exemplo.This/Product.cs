using System;

namespace Capitulo5.Exemplo.This
{
    public class Product
    {
        public string Name { get; protected set; }
        private decimal _price;
        public decimal SellPrice { get; protected set; }
        public string CodeBar { get; protected set; }
        public int Amount { get; protected set; }

        public Product(string name, decimal price, string codeBar, int amount)
        {
            SetName(name);
            SetProductPrice(price);
            CodeBar = codeBar;
            Amount = amount;
        }

        public void SetProductPrice(decimal price)
        {
            if (price == 0)
            {
                Console.WriteLine("Valor não pode ser zero!");
                return;
            }

            _price = price;
            SellPrice = _price + (_price * 0.30m);
        }

        public void SetName(string name)
        {
            name = name.Replace(" ", "");
            if (name != null) Name = name.ToUpper();
        }

        public void AddProduct(int quantity) => Amount += quantity;
        public void RemoveProduct(int quantity) => Amount -= quantity;

        public override string ToString()
        {
            return Name + " " + SellPrice.ToString("F2") + " " + CodeBar + " " + Amount;
        }

    }
}
