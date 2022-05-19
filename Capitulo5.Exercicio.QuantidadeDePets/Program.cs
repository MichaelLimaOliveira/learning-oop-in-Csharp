using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5.Exercicio.QuantidadeDePets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;

            Console.WriteLine("Controle de animais");

            //Primeiro animal
            Console.Write("Informe o nome do 1 animal: ");
            a1.Name = Console.ReadLine();

            Console.Write("Informe o tipo do 1 animal (Cachorro, Gato ou Peixe): ");
            a1.AnimalType = Console.ReadLine();

            if(a1.AnimalType == "Cachorro") tlCachorro++;
            if(a1.AnimalType == "Gato") tlGato++;
            if(a1.AnimalType == "Peixe") tlPeixe++;

            //Segundo animal
            Console.Write("Informe o nome do 2 animal: ");
            a2.Name = Console.ReadLine();

            Console.Write("Informe o tipo do 2 animal (Cachorro, Gato ou Peixe): ");
            a2.AnimalType = Console.ReadLine();

            if (a2.AnimalType == "Cachorro") tlCachorro++;
            if (a2.AnimalType == "Gato") tlGato++;
            if (a2.AnimalType == "Peixe") tlPeixe++;

            //Terceiro animal
            Console.Write("Informe o nome do 3 animal: ");
            a3.Name = Console.ReadLine();

            Console.Write("Informe o tipo do 3 animal (Cachorro, Gato ou Peixe): ");
            a3.AnimalType = Console.ReadLine();

            if (a3.AnimalType == "Cachorro") tlCachorro++;
            if (a3.AnimalType == "Gato") tlGato++;
            if (a3.AnimalType == "Peixe") tlPeixe++;

            //Quarto animal
            Console.Write("Informe o nome do 4 animal: ");
            a4.Name = Console.ReadLine();

            Console.Write("Informe o tipo do 4 animal (Cachorro, Gato ou Peixe): ");
            a4.AnimalType = Console.ReadLine();

            if (a4.AnimalType == "Cachorro") tlCachorro++;
            if (a4.AnimalType == "Gato") tlGato++;
            if (a4.AnimalType == "Peixe") tlPeixe++;

            //Quinto animal
            Console.Write("Informe o nome do 5 animal: ");
            a5.Name = Console.ReadLine();

            Console.Write("Informe o tipo do 5 animal (Cachorro, Gato ou Peixe): ");
            a5.AnimalType = Console.ReadLine();

            if (a5.AnimalType == "Cachorro") tlCachorro++;
            if (a5.AnimalType == "Gato") tlGato++;
            if (a5.AnimalType == "Peixe") tlPeixe++;

            //resultado
            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorros: " +tlCachorro+" \nGatos: "+tlGato+" \nPeixes: "+tlPeixe);


        }
    }
}
