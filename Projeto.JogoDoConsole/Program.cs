using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.JogoDoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Scenario c = new Scenario("_", 100, 10);

            ConsoleKey key;
            do
            {
                Task.Delay(200);
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
                    case ConsoleKey.DownArrow:
                        p1.Jump = false;
                        break;
                }
                c.ScenarioPrinter(p1);

            } while (key != ConsoleKey.Escape);
        }
    }
}
