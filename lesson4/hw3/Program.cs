// Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
//пример вывода
//[1,4,5,3,1,2,3,9]

Console.WriteLine("массив из 8 элементов с диапазоном значения от 1 до 100:");

int[] array = new int[8];

void FillArray(int[] massiv1)
{
    
    int length = massiv1.Length;
    int i = 0;

    while (i < length)
    {
        massiv1[i] = new Random().Next(1, 100);
        i++;
    }
}

void PrintArray(int[] massiv2)
{
    int length = massiv2.Length;
    int i = 0;
    while(i<length) 
    {
        Console.Write($"{massiv2[i]}, ");
        i++;
    }
}
FillArray(array);
PrintArray(array);