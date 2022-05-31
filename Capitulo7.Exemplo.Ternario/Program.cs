using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7.Exemplo.Ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = Convert.ToDouble(Console.ReadLine());
            int quantity = Convert.ToInt32(Console.ReadLine());


            double discount = (price > 20) ? price * 0.1 : price * 0.05;
            double discountPerQuantity = (quantity > 200) ? price * 0.4 : price * 0.05;

            Console.WriteLine(discount);
            Console.WriteLine(discountPerQuantity);

            Console.WriteLine();

            double sum = price * quantity;
            Console.WriteLine(sum);
            sum -= discount + discountPerQuantity;
            Console.WriteLine(sum);
        }
    }
}