using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7.Exemplo.ExercicioDataTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2018, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("ToLongDateString: " + d.ToLongDateString());
            Console.WriteLine("ToLongTimeString: " + d.ToLongTimeString());
            Console.WriteLine("ToShortDateString: " + d.ToShortDateString());
            Console.WriteLine("ToShortTimeString: " + d.ToShortTimeString());
            Console.WriteLine("ToString: " + d.ToString("yyyy-MM-dd HH:mm:ss"));


            DateTime d2 = d.AddHours(2);
            DateTime d3 = d2.AddMinutes(3);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            DateTime dateAtual = DateTime.Now;
            var d4 = dateAtual.AddDays(7);
            TimeSpan t = d4.Subtract(dateAtual);

            Console.WriteLine(d4);
            Console.WriteLine(t);

        }
    }
}
