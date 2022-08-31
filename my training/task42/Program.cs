//42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();
Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[size];

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FillArrayFromKeyboard(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число для заполнения массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int howManymore(int[] array)
{
    int MoreThanZero = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            MoreThanZero++;
        }
    }
    return MoreThanZero;
}

FillArrayFromKeyboard(mass);
PrintArray(mass);
Console.WriteLine();
Console.WriteLine($"{howManymore(mass)} чисел в массиве больше 0");
