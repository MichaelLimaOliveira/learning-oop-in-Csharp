using Capitulo4.Exemplo.Override.AnimalNamespace;

namespace Capitulo4.Exemplo.Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printer = new GenericPrinter<Animal>();
            Dog cachorro = new Dog(20, 2, "Rex");
            Cat gato = new Cat(20, 2, "Lili", "Vermelho");
            Bird bird = new Bird(1, 1, 2, "Piu");

            printer.PrintName(cachorro);
            printer.PrintName(gato);
            printer.PrintName(bird);
        }
    }
}