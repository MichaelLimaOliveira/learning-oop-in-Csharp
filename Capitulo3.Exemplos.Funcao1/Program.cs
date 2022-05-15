namespace Capitulo3.Exemplos.Funcao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os 3 numeros para comparar (Um apos o outros): ");
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());

            int result;
            Console.WriteLine($"O maior entre os 3 e: {result = MaxNumber(numberA, numberB, numberC)}");

            Console.Write("Digite quantos valores quiser para testar o maior (Todos na mesma linha): ");
            int[] vet = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(result = Maior(vet));

            Console.Write("Digite quantos valores quiser para testar o menor (Todos na mesma linha): ");
            vet = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(result = Minimal(vet));

        }

        static int MaxNumber(int a, int b, int c)
        {
            int _maxNumber;
            if (a > b && a > c)
                _maxNumber = a;
            else if (b > c)
                _maxNumber = b;
            else
                _maxNumber = c;

            return _maxNumber;
        }

        static int Maior(int[] vet)
        {
            int _max = vet[0];
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] > _max)
                    _max = vet[i];
            }
            return _max;
        }

        static int Minimal(int[] vet)
        {
            int _minimal = vet[0];
            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[vet[i]] < _minimal)
                    _minimal = vet[i];
            }
            return _minimal;
        }
    }
}