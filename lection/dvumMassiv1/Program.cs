// int[,] matrix = new int[3,4];

// for(int str1 = 0; str1 < matrix.GetLength(0); str1++) 
// {
    
//     for(int stolb1 = 0; stolb1 < matrix.GetLength(1); stolb1++)
//     {
//         matrix[str1,stolb1] = new Random().Next(1, 100);
//         Console.Write($"{matrix[str1, stolb1]} ");
//     }
// Console.WriteLine();
// }

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

int[,] matrix = new int[3,5];

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
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);