// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0)
// 25(0,1,0)
// 34(1,0,0)
// 41(1,1,0)
// 27(0,0,1)
// 90(0,1,1)
// 26(1,0,1)
// 55(1,1,1)



Console.Clear();


int[,,] matrix = new int[2, 2, 2];

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // (0) строка
    {
        for (int j = 0; j < matr.GetLength(1); j++) // (1) столбец
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.WriteLine($"{matr[i, j, k]} = i({i}), j({j}), k({k})");
            }
        }
    }
}
 
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


