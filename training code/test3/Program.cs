int[] array1 = { 9, 5, 9, 6, 7, 4, 3, 8, 2, 3, 3, 6, 6 };

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length -1; i++)
    {
        int minPos = i;
        for (int j=i +1; j < array.Length ; j++)
        {
            if(array[j] < array[minPos]) minPos = j;
        }

        int temp = array[i];
        array[i]=array[minPos];
        array[minPos]=temp;
    }


}

PrintArray(array1);
SelectionSort(array1);
PrintArray(array1);