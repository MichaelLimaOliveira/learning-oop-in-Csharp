namespace Capitulo4.ExercicioDeFixacao.Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a cotaçao do dólar?  ");
            double quotation = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares voce vai comprar? ");            
            double valueDollar = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reias? {CurrencyConverter.ValueInReais(valueDollar,quotation):F2}");

        }
    }
}