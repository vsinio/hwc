// 54. В матрице чисел найти сумму элементов главной диагонали

int[,] matrix = new int[5, 5];

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

int SummaDiag(int[,] matr)
{
    int summ = 0;
    for (int i = 0; i < matr.GetLength(0); i++)  // (0) строка
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // (1) столбец 
        {
            if(i==j)
            {
                summ=summ+matr[i,j];
            }
        }
    }
    return summ;
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine(SummaDiag(matrix));