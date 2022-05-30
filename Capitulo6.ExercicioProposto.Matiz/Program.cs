using System;

namespace Capitulo6.ExercicioProposto.Matiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] aux = Console.ReadLine().Split(' ');
            int l = Convert.ToInt32(aux[0]);
            int c = Convert.ToInt32(aux[1]);

            int[,] numbers = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] aux2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                    numbers[i, j] = Convert.ToInt32(aux2[j]);
            }

            int searchNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.GetLength(0); i++)
                for (int j = 0; j < numbers.GetLength(1); j++)
                    if (numbers[i, j] == searchNumber)
                    {
                        Console.WriteLine($"Position: {i},{j}");
                        if (j > 0)
                            Console.WriteLine($"Left: {numbers[i, j - 1]}");
                        if (j < c - 1)
                            Console.WriteLine($"Right: {numbers[i, j + 1]}");
                        if (i > 0)
                            Console.WriteLine($"Up: {numbers[i - 1, j]}");
                        if (i < l - 1)
                            Console.WriteLine($"Down: {numbers[i + 1, j]}");
                    }
        }
    }
}
