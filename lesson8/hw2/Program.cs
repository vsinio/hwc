
// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.Clear();

Console.WriteLine("Введите количество строк массива:");
int sizeLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int sizeColumn = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[sizeLine, sizeColumn];

void maxSummPrint(int[,] matrix)
{
    int realMin = 11;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        int minimum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            
            {
                minimum = minimum + matrix[i,j];
            }
                if(minimum < realMin)
                {
                    realMin = minimum;
                    index = i+1;
                }
            
    }
    Console.WriteLine($"сумма строки #{index} = {realMin}");
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
PrintArray(matrix);
maxSummPrint(matrix);
