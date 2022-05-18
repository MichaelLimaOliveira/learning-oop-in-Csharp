namespace Capitulo4.Exemplo.Static
{
    internal class Calculator
    {
        public static double Pi = 3.14;
        //public const double Pi = 3.14; e a mesma coisa da linha 5

        public static double Circumference(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
