namespace Capitulo4.ExercicioDeFixacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Entre com a largura e altura do retangulo:");
            rectangle.Width = double.Parse(Console.ReadLine());
            rectangle.Height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {rectangle.Area():F2}");
            Console.WriteLine($"Perimetro = {rectangle.Perimeter():F2}");
            Console.WriteLine($"Diagonal = {rectangle.Diagonal():F2}");
        }
    }
}