// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] mass = new int[4];

void PrintArray(int[] array)
{
    int length = array.Length;
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
        if (array[i] > max)
            max = array[i];
        if (array[i] < max)
            min = array[i];
        Console.Write($"{array[i]} ");
    }
    Console.Write($"разница => max({max})-min({min})= {max - min}");
}

PrintArray(mass);
