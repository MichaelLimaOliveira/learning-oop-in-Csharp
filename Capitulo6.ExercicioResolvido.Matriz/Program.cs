using System;

namespace Capitulo6.ExercicioResolvido.Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {

                    numbers[i, j] = Convert.ToInt32(aux[j]);
                }
            }

            Console.WriteLine("Main Diagonal: ");

            for (int i = 0; i < n; i++)
                        Console.Write(numbers[i, i] + " ");

            Console.WriteLine();

            int count = 0;

            foreach (int i in numbers)
                if (i < 0)
                    count++;

            Console.WriteLine("Negative numbers = " + count);
        }
    }
}
