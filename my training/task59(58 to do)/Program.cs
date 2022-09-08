// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.


int[,] matrix = new int[4, 15];

void PrintArrayOne(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++) // (0) строка
    {
        for (int j = 0; j < matr1.GetLength(1); j++) // (1) столбец
        {
            matr1[i, j] = new Random().Next(1, 10);
            ;
        }
    }
}

int[] LowStrok(int[,] matr)
{
    int[] low = new int[matr.GetLength(0)];
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++) // (0) строка
    {
        int summ = 0;
        for (int j = 0; j < matr.GetLength(1); j++) // (1) столбец
        {
            summ = summ + matr[i, j];
        }
        low[index] = summ;
        index++;
    }
    return low;
}

int LowFromOthers(int[] arr)
{
    int length = arr.Length;
    int lowest = arr[0];

    for (int i = 0; i < length; i++)
    {
        if (lowest > arr[i])
        {
            lowest = arr[i];
        }
    }
    return lowest;
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.Write("суммы строк = ");
PrintArrayOne(LowStrok(matrix));
Console.WriteLine($"Наименьшая сумма строк = {LowFromOthers(LowStrok(matrix))}");
