namespace Capitulo4.Exemplo.Override.AnimalNamespace
{
    internal abstract class Animal : IModelBase
    {
        public Animal (int weight, int height, string name)
        {
            Weight = weight;
            Height = height;
            Name = name;
        }

        public int Weight { get; protected set; }
        public int Height { get; protected set; }
        public string Name { get; protected set; }

        public abstract string NameToString();

        public abstract string Noise();
        public virtual string WalkMode()
        {
            return "Four legs";
        }
    }
}
