namespace Capitulo4.ExercicioDeFixacao.Static
{
    internal class CurrencyConverter
    {
        private const double IOF = 0.06;

        public static double ValueInReais(double dollares, double quotation)
        {
            return (quotation * dollares) + ((quotation * dollares) * IOF);
        }
    }
}
