// 56. Написать программу, которая обменивает элементы первой строки и последней строки


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

void firstlastSwap(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // (0) строка
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // (1) столбец 
        {
            int temp = matr[0,j];
            matr[0,j] = matr[3, j]; 
            matr[3, j] = temp;
        }
    break;
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
firstlastSwap(matrix);
PrintArray(matrix);