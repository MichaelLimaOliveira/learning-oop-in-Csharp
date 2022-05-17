namespace Capitulo4.Teste.MenbrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Printer();
            //Program.Printer(); nao vai funcionar pq nao e static 

            //program.Count(); nao posso instanciar menbro static
            Program.Count();


            Console.WriteLine(program.Sum(12, 12));

            Program program1 = new Program();

            Console.WriteLine(program1.Sum(6, 6));

            Console.WriteLine(program.Sum(2,2)- program1.Sum(4,4));
            Console.WriteLine(Program.Subtraction(10,2)+Program.Subtraction(5,2));
        }

        public void Printer()
        {
            Console.WriteLine("foi");

        }

        static public void Count()
        {
            Console.WriteLine("1, 2, 3, 4, 5");

            Program program = new Program();
        }

        public int Sum(int valueA, int valueB)
        {
            return valueA + valueB;
        }
        static int Subtraction(int valueA, int valueB)
        {
            return valueA - valueB;
        }
    }
}