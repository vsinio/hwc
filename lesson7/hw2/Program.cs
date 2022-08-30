// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет

Console.Clear();

int[,] matrix = new int[3, 4];

void searchelement(int[,] matr1)
{
    Console.WriteLine("Введите позицию элемента:");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = a / 10;
    int c = a % 10;

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        if(b>matr1.GetLength(0) || c>matr1.GetLength(1)) 
        {
            Console.WriteLine("Элемента нет");
            break;
        } 
        for (int j = 0; j < matr1.GetLength(1); j++)
        {   
            if(c>matr1.GetLength(1) || b>matr1.GetLength(0)) 
            {
                Console.WriteLine("Элемента нет");
                break;
            }
            if (a == (i + 1) * 10 + (j + 1))
            {
                Console.WriteLine($"элемент под номером {a} = {matr1[i, j]}");
            }
        }
    }
}

void PrintArray(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++) //getl(0) строка
    {
        for (int j = 0; j < matr1.GetLength(1); j++) // getl(1) столб
        {
            Console.Write($"{matr1[i, j]} "); //разделил палками для читабельности тк нет запятых + просьба, помогите со способом
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

FillArray(matrix);
PrintArray(matrix);
searchelement(matrix);
