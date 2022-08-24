// 33. Задать массив из 12 элементов, заполненных числами из [0,9]*Сделал правку от -9 до 9, чтобы были отр числа*.
// Найти сумму положительных/отрицательных элементов массива
Console.Clear();

int[] mass = new int[12];

void PrintArray(int []array)
{
    int length = array.Length;
    int pol = 0;
    int otr = 0;

    for(int i=0; i < length;i++)
    {
        array[i] = new Random().Next(-10,10);
        Console.Write($"{array[i]} ");
        if(array[i] > 0) pol++;
        if(array[i] < 0) otr++;
    }
    Console.WriteLine($"кол-во положительных = {pol}, кол-во отрицательных = {otr} !");
}

PrintArray(mass);