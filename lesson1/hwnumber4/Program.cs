Console.Write("Введите число А сравнения:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б сравнения:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число С сравнения:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b) max = a;
if (b > a) max = b;
if (c > a) max = c;

Console.Write("max = ");
Console.Write(max);



