﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7.Exemplo.Timespans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(2, 11, 21);
            TimeSpan t3 = new TimeSpan(900000000l);
            TimeSpan t4 = TimeSpan.FromDays(1.5);
            TimeSpan t5 = TimeSpan.FromHours(1.5);
            TimeSpan t6 = TimeSpan.FromMinutes(1.5);
            TimeSpan t7 = TimeSpan.FromSeconds(1.5);
            TimeSpan t8 = TimeSpan.FromTicks(900000000l);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
        }
    }
}
