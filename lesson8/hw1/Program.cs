// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



Console.Clear();

Console.WriteLine("Введите количество строк массива:");
int sizeLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int sizeColumn = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[sizeLine, sizeColumn];

void SelectionSort(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1)-1; j++)
        {   
            int MaxPos = matr[i,j];
            for(int k = j+1; k < matr.GetLength(0); k++)
            {           // 1 4 7 2
                if(matr[i,j] < MaxPos)
                {
                    MaxPos = matr[i,j];
                }
            }
            int temp = matr[i,j];
            matr[i,j] = MaxPos;
            MaxPos = temp;


           
        }
        
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // (0) строка
    {
        for (int j = 0; j < matr.GetLength(1); j++) // (1) столбец
        {
            matr[i, j] = new Random().Next(1, 10);
        }
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

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SelectionSort(matrix);
PrintArray(matrix);
