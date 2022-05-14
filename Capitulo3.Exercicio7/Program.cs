namespace Capitulo3.Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio1");
            int number = int.Parse(Console.ReadLine());

            Comparer(number);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Exercicio2");
            number = int.Parse(Console.ReadLine());

            IsEven(number);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Exercicio3");
            int[] vet = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            IsMultiples(vet[0], vet[1]);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Exercicio4");

            vet = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            GameTime(vet[0], vet[1]);



        }

        static void Comparer(int value)
        {
            if (value >= 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("NEGATIVO");
        }
        static void IsEven(int value)
        {
            if (value % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
        static void IsMultiples(int value1, int value2)
        {
            if (value2 % value1 == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
        }
        static void GameTime(int value1, int value2)
        {
            int _totalTime;

            if (value1 >= value2)
                _totalTime = (value2 + 24) - value1;
            else            
                _totalTime = value2 - value1;
            
            Console.WriteLine($"O JOGO DUROU {_totalTime} HORA(S)");

        }

    }
}