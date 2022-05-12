
using System.Globalization;

string[] firstEnter = Console.ReadLine().Split(' ');
string[] secondEnter = Console.ReadLine().Split(' ');

double coutFirst = double.Parse(firstEnter[1], CultureInfo.InvariantCulture);
double coutSecond = double.Parse(secondEnter[1], CultureInfo.InvariantCulture);

double firstPrice = double.Parse(firstEnter[2], CultureInfo.InvariantCulture);
double secondPrice = double.Parse(secondEnter[2], CultureInfo.InvariantCulture);

double totalValue = (coutFirst * firstPrice) + (coutSecond * secondPrice);

Console.WriteLine("Total a pagar: " +totalValue.ToString("F2", CultureInfo.InvariantCulture));