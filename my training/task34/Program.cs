// 34. Написать программу замену элементов массива на противоположные
Console.Clear();

int[] mass = { 14, 32, 434, 54, 74, 3, -55, -789, -555, -1234 };

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ReverseIntArray(int[] array)
{
    int length = array.Length;

    for(int i=0; i<length;i++)
        {
            array[i] = -array[i];
        }
}

PrintArray(mass);
ReverseIntArray(mass);
Console.WriteLine();
PrintArray(mass);
