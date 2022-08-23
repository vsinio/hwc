//  1. По двум заданным числам проверять является ли первое квадратом второго
Console.Clear();
Console.WriteLine("Введите два числа для проверки:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a*a == b)
{
    Console.WriteLine("Да, является");
}
else
{
    Console.WriteLine("Нет, не является");    
}

