// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
Console.Clear();

int[] mass = new int[8];

void PrintArray(int []array)
{
    int length = array.Length;

    for(int i=0; i < length;i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i]} ");
    }
}

PrintArray(mass);
