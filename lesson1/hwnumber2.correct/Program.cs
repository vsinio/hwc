//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число А сравнения:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б сравнения:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("max = ");
    Console.Write(a);
    Console.Write("min = ");
    Console.Write(b);
}
else
{
    Console.Write("max = ");
    Console.Write(b);
    Console.Write("min = ");
    Console.Write(a);
}


