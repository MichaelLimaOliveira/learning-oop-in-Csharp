//int a = 5;
//int b = 6;
//a -= b;
//Console.WriteLine(a);

//int cont = 0;
//for (int i = 0; i < 10; ++i)
//{
//    cont++;
//    Console.WriteLine($"i :{i}");
//    Console.WriteLine($"cont :{cont}");
//    break;
//}



using System.Globalization;

int a = 257;
byte b = (byte)a;

sbyte d = 127;

d += 100;
Console.WriteLine(d);
string x;
int y;
double z;
char w;

x = Console.ReadLine();
y = int.Parse(Console.ReadLine());
z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
w = char.Parse(Console.ReadLine());

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(w);
