using System;
using System.Threading.Tasks;

namespace Projeto.JogoDoConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Player p1 = new Player();
            Scenario c = new Scenario("_", 100, 10);
            
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        p1.Movement('L');
                        break;
                    case ConsoleKey.RightArrow:
                        p1.Movement('R');
                        break;
                    case ConsoleKey.UpArrow:
                        p1.Jump = true;
                        break;
                }
                await c.ScenarioPrinterAsync(p1);
            } while (key != ConsoleKey.Escape);
        }
    }
}
