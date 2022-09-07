// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


int[,] matrix = new int[8, 8];

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

void twoEvenIndex(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // (0) строка
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // (1) столбец
        {
            if((i%2==0) & (j%2==0) & i!=0 & j!=0)
            {
                matr[i,j] = i*i + j*j;
            }
        } 
    }
}

FillArray(matrix);
PrintArray(matrix);
twoEvenIndex(matrix);
Console.WriteLine();
PrintArray(matrix);