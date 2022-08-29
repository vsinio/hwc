// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.Clear();

double[,] matrix = new double[3, 4];

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //getl(0) строка
    {
        for (int j = 0; j < matr.GetLength(1); j++) // getl(1) столб
        {
            Console.Write($"|{matr[i, j]}| "); //разделил палками для читабельности тк нет запятых + просьба, помогите со способом
            // для добавления вещественных в массив без костылей, которые снизу ( new random / 10 )
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(-100, 100);
            matr1[i, j] = matr1[i, j] / 10;
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine("_______");
PrintArray(matrix);
