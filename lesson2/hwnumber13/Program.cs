Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 & a < 1000)
{
    Console.Write(a % 10);
}
else if (a < 100)
{
    Console.Write("третьей цифры нет");
}
else if (a > 1000)
{
    while (a > 1000)
    a = a / 10;
    Console.Write(a % 10);        
}