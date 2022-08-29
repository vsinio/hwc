// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4


int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"|{matr[i, j]}| "); //разделил палками для читабельности тк нет запятых + просьба, помогите со способом
            // для добавления вещественных в массив без костылей, которые снизу ( new random / 10 )
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(0, 10);
        }
    }
}

void srarfm(int[,] matr1)
{
    
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        double f = 0;
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
         f = matr1[i,j]+f;
        }
    Console.WriteLine($"Среднее арифм {i+1} столбца = {f/4} ");
    }
}


PrintArray(matrix);
FillArray(matrix);
Console.WriteLine("---------------");
PrintArray(matrix);
srarfm(matrix);
