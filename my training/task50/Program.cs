// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] matrix = new int[4, 4];

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
            matr1[i, j] = new Random().Next(1, 10);
        }
    }
}

void ReplaceEven(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // (0) строка
    {
        for (int j = 1; j < matr.GetLength(1); j=j+2)  // (1) столбец
        {
            matr[i,j] = -matr[i,j];
        } 
    }
}

FillArray(matrix);
PrintArray(matrix);
ReplaceEven(matrix);
Console.WriteLine();
PrintArray(matrix);