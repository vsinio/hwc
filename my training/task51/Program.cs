// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n


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


void arrayMN(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // (0) строка
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // (1) столбец
        {
            matr[i,j] = i+j;
        } 
    }
}

PrintArray(matrix);
arrayMN(matrix);
Console.WriteLine();
PrintArray(matrix);