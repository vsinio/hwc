// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Clear();
Console.WriteLine("Введите число M и N:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа от M={a} до N={b}");
void fromAtoB(int a, int b)
{
    for (int i = a; i <= b; i++)
    {
        if (i < b)
        {
            Console.Write($"{i},");
        }
        else
        {
            Console.Write(i);
        }
    }
}
fromAtoB(a, b);
