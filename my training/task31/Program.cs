//31. Задать массив из 8 элементов и вывести их на экран 
Console.Clear();

int[] mass = new int[8];

void PrintArray(int []array)
{
    int length = array.Length;

    for(int i=0; i < length;i++)
    {
        array[i] = 0;
        Console.Write($"{array[i]} ");
    }
}

PrintArray(mass);