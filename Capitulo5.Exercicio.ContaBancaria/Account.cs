namespace Capitulo5.Exercicio.ContaBancaria
{
    internal class Account
    {
        private double _tax = 5.00;
        public string ID { get; private set; }
        public string Name { get; private set; }

        public double Balance { get; private set; }

        public Account(string iD, string name)
        {
            ID = iD;
            Name = name;
        }
        public Account(string iD, string name, double initialDeposit) : this(iD, name)
        {
            DepositMoney(initialDeposit);
        }

        public void DepositMoney(double quantity)
        {
            Balance += quantity;
        }

        public void DrawMoney(double quantity)
        {
            Balance -= quantity + _tax;
        }

        public void ChangeName(string name)
        {
            if (name != this.Name && name != null) this.Name = name;
        }

        public override string ToString()
        {
            return $"Conta {ID}, Titular: {Name}, Saldo: $ {Balance:F2}";
        }

    }
}
