//17. По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Введите два числа для проверки:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a==b*b)
{
    Console.WriteLine($"Да, число {b} является квадратом числа {a}");
}
if(b==a*a)
{
    Console.WriteLine($"Да, число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Нет, ни {a}, ни {b} не являются квадратом друг друга");
}