using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7.Exemplo.SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var days = "";

            if (n == 1)
                days = "Sunday";
            else if (n == 2)
                days = "Monday";
            else if (n == 3)
                days = "Tuesday";
            else if (n == 4)
                days = "Wednesday";
            else if (n == 5)
                days = "Thursday";
            else if (n == 6)
                days = "Friday";
            else if (n == 7)
                days = "Saturday";
            else
                days = "Invalid value";

            Console.WriteLine($"Day: {days}");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    days = "Sunday";
                    break;
                case 2:
                    days = "Monday";
                    break;
                case 3:
                    days = "Tuesday";
                    break;
                case 4:
                    days = "Wednesday";
                    break;
                case 5:
                    days = "Thursday";
                    break;
                case 6:
                    days = "Friday";
                    break;
                case 7:
                    days = "Saturday";
                    break;
                default:
                    days = "Invalid value";
                    break;

                    Console.WriteLine($"Day: {days}");

            }
        }
    }
}
