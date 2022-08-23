// ДВУМЕРНЫЕ МАССИВЫ
//string[,] table = new string[2,3]; // [,] = указание
//размерности. 1 размерность строки, 2 - столбцы// таблица из строк
//int[,] matrix = new int[5,8]; //двумерный массив из двух столбцов чисел
//                   5 - строки 
//                   8 - столбцы
//изначально все элементы = String.Empty;
// string[,] table = new string[2,5];       // table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4] 
// table[1,2] = "слово";                    // table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4] 

// for(int str = 0; str < 2; str++)
// {
//     for(int stolb = 0; stolb < 5; stolb++)
//     {
//     Console.WriteLine($"+{table[str, stolb]}+");
//     }
// }

int[,] matrix = new int[3,4];

for(int str1 = 0; str1 < matrix.GetLength(0); str1++) //вместо 3 [str1 < 3;] можно написать matrix.GetLenght(0) " 0 - количество строк"
{
    
    for(int stolb1 = 0; stolb1 < matrix.GetLength(1); stolb1++) //вместо 4 [stolb1 < 4;] можно написать matrix.GetLenght(1) " 1 - количество столбов"
    {
        matrix[str1,stolb1] = new Random().Next(1, 100);
        Console.Write($"{matrix[str1, stolb1]} ");
    }
Console.WriteLine();
}