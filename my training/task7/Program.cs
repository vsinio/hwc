//  7. Показать числа от -N до N
Console.Clear();

Console.WriteLine("Введите число N от 1 до 1000000000");
int n = Convert.ToInt32(Console.ReadLine());
int minus = -n;

while(minus !=n)
{
    Console.Write($"{minus} ,");
    minus ++;
}

Console.Write(minus);

