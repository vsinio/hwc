//  8. Показать четные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа от 1 до {a}:");
int i = 0;
while(i<=a-2)
{
    i = i+2;
    Console.WriteLine(i);

}

