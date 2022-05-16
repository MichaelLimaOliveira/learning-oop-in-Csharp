namespace Capitulo4.Exemplo.Override.AnimalNamespace
{
    internal class Cat : Animal
    {
        public Cat(int weight, int height, string name, string color) : base(weight, height, name)
        {
            Color = color;
        }

        public string Color { get; }

        public override string Noise()
        {
            return "Nyan";
        }

        public override string NameToString()
        {
            return $"Cat name is: {Name}";
        }
    }
}