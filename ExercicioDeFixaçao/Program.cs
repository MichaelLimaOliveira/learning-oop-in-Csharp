
using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de Escritorio";

byte idade = 30;
int codigo = 5290;
char genero = 'M';
double preco1 = 2100.0;
double preco2 = 650.50;
double media = 53.234567;

Console.WriteLine("Produtos:");
//Interpolaçao $"" antes da string

Console.WriteLine($"{produto1}, cujo preço e $ {preco1:F2}");

//placeholders {0},"namevariavel"
Console.WriteLine("{0}, cujo preço e $ {1:F2}", produto2, preco2);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {'M'}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Medida com oito casa decimais: {media:F8}");
Console.WriteLine($"Arredondado (três casas decimais): {media:F3}");
Console.WriteLine($"Separador decimal invariant culture: {media.ToString("F3", CultureInfo.InvariantCulture)}");