using System.Globalization;

Console.WriteLine("Entre com seu nome completo:");
string name = Console.ReadLine();
Console.WriteLine("Quantos quartos tem sua casa:");
int bedRooms = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o precço de um produto: ");
double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com seu ultimo nome, idade, altura(na mesma linha):");
string[] vet = Console.ReadLine().Split(' ');

Console.WriteLine(name);
Console.WriteLine(bedRooms);
Console.WriteLine(price);
Console.WriteLine(vet[0]);
Console.WriteLine(vet[1]);
Console.WriteLine(vet[2],CultureInfo.InvariantCulture);
