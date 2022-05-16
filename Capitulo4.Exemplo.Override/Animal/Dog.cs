namespace Capitulo4.Exemplo.Override.AnimalNamespace
{
    internal class Dog : Animal
    {
        public Dog(int weight, int height, string name) : base(weight, height, name)
        {
        }

        public override string Noise()
        {
            return "Whoof";
        }

        public override string WalkMode()
        {
            return "Twenty Thousand legs";
        }

        public override string NameToString()
        {
            return $"Dog name is: {Name}";
        }
    }
}
