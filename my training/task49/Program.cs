// 49. Показать двумерный массив размером m×n заполненный вещественными числами
double[,] matrix = new double[4, 4];


void PrintArray(double[,] matr)
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

void FillArray(double[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)  // (0) строка
    {
        for (int j = 0; j < matr1.GetLength(1); j++)  // (1) столбец 
        {
            matr1[i, j] = new Random().Next(10, 100);
            matr1[i,j] = matr1[i,j] / 10;
        }
    }
}

FillArray(matrix);
PrintArray(matrix);