// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.WriteLine("Введите число, которое ищите (1 - 10):");


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
void SearchInt(int[,] matr)
{
    int index = 0;
    int a = Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
            
            if(matr[i,j] == a)
            {
                Console.WriteLine($"Указанное число {a} находится на позиции с индексом = [{i},{j}]");
                index++;
            }

        }
    
        
    }
    if(index==0)
    {
        Console.WriteLine("Искомого числа нет :(");
    }
}
FillArray(matrix);
PrintArray(matrix);
SearchInt(matrix);