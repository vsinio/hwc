// 26. Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.WriteLine("Введите число А для его возведения в степень B");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a;
int step = 0;
while (step < b)
{
    c = c * a;
    step++;
}
Console.WriteLine(c);

Console.WriteLine("Введите число А для его возведения в степень B");
int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = a1;
for (int index = 0; index < b1; index++)
{
    c1 = c1 * a1;
}
Console.WriteLine(c1);
