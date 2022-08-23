// метод создания и вывода нового двум массива

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++) 
    {
    
        for(int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
    Console.WriteLine();
        }
}



//метод генерации чисел в заданном масиве
void FillArray(int[,] matr1)
{
    for(int i = 0; i < matr1.GetLength(0); i++) 
    {
    
        for(int j = 0; j < matr1.GetLength(1); j++)
            {
                matr1[i,j] = new Random().Next(1, 10);
                
            }
        }
}


int[,] matrix = new int[3,5];


//создание массива + вывод =>заполнение => вывод результата

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);