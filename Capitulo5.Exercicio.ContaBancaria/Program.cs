using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5.Exercicio.ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1;
            Console.Write("Entre com o numero da conta: ");
            string id = Console.ReadLine();

            Console.Write("entre com o nome do titular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char validation = char.Parse(Console.ReadLine());

            double balance;
            if(validation == 's')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                balance = double.Parse(Console.ReadLine());
                a1 = new Account(id,  name, balance);
            }
            else
            {
                a1 = new Account(id, name);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(a1);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            a1.DepositMoney(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(a1);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            a1.DrawMoney(double.Parse(Console.ReadLine()));
            Console.WriteLine(a1);

            

        }
    }
}
