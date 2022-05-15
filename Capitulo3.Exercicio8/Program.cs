namespace Capitulo3.Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio1");

            int code = int.Parse(Console.ReadLine());
            PassWorld(code);

            Console.WriteLine("Exercicio2");

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Esse sao os numeros impar de 1 ate {number}:");
            AllOddNumber(number);
        }

        static void PassWorld(int code)
        {
            const int _realCode = 2002;

            while (code != _realCode)
            {
                Console.WriteLine("Senha Invalida");
                code = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta");
        }

        static void  AllOddNumber (int limitValue)
        {
            for (int i = 1; i < limitValue; i++)
                if (i % 2 != 0)
                    Console.WriteLine(i);
            
        
        }
    }
}