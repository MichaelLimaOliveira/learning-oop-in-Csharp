using Capitulo4.Exemplo.Override.AnimalNamespace;

namespace Capitulo4.Exemplo.Override
{
    internal class GenericPrinter<T> where T : IModelBase
    {
        public void PrintName(IModelBase modelBase)
        {
            Console.WriteLine(modelBase.NameToString());
        }
    }
}
