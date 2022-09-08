// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы
//  или сообщить, что это невозможно (в случае, если матрица не квадратная).


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
            matr1[i, j] = i+1;
        }
    }
}

void Swap(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // (0) строка
    {

        for (int j = 0; j < matr.GetLength(1); j++)  // (1) столбец 
        {
            int temp = matr[i,j];
            matr[j,i] = matr[i, j]; 
            matr[j, i] = temp;
        }
        break;
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Swap(matrix);
PrintArray(matrix);