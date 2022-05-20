using System;

namespace Capitulo5.Exemplo.Properties
{
    internal class Product
    {
        private string _name;

        public int Amount { get; private set; }

        public double Price { get; private set; }

        public Product(string name, int amount, double price)
        {
            _name = name.ToUpper();
            Amount = amount;
            Price = price + (price * 0.30);
        }

        public string Name
        {
            get { return _name; }
            set { if (value != null && value.Length > 1) _name = value; }
        }

        //public double Price => _price;

        //public int Amount => _amount;

        public void AddAmount(int quantity)
        {
            if (quantity > 0) Amount += quantity;
        }

        public void RemoveAmount(int quantity)
        {
            if (quantity > 0) Amount -= quantity;
        }

        public double TotalStockValue() => Price * Amount;

        public override string ToString()
        {
            return "Name: " + Name
                            + ", Preço: "
                            + Price.ToString("F2");
        }
    }
}
