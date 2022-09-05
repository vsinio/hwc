// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число M и N:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

void summaNaturalInt(int a, int b)
{
    int c = 0;
    for (int i = a; i <= b; i++)
    {
        {
            c=c+i;
        }
    }
    Console.WriteLine($"Сумма натуральных чисел от M({a}) до N({b}) => {c}");
}
summaNaturalInt(a,b);