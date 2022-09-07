// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] matrix = new int[4,4];

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
    for (int i = 0; i < matr1.GetLength(0); i++)  // (0) строка
    {
        for (int j = 0; j < matr1.GetLength(1); j++)  // (1) столбец 
        {
            matr1[i, j] = new Random().Next(1, 10);;
        }
    }
}

void SrArfm(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)  // (0) строка
    {
        int summ = 0;
        for (int j = 0; j < matr.GetLength(1); j++)  // (1) столбец 
        {
            summ=summ + matr[i,j];
        }
        Console.WriteLine($"ср арфм столбца {i+1} = {summ / matr.GetLength(1)}");
    }
}

FillArray(matrix);
PrintArray(matrix);
SrArfm(matrix);