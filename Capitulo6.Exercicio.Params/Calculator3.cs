namespace Capitulo6.Exercicio.Params
{
    internal class Calculator3
    {
        public static int Calc(params int[] vet)
        {
            int sum = 0;
            foreach (int i in vet)
            {
                sum += i;
            }
            return sum;
        }
    }
}
