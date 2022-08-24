// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
int[] mass = new int[4];

void PrintArray(int []array)
{
    int length = array.Length;
    int summ = 0;

    for(int i=0; i < length;i++)
    {
        array[i] = new Random().Next(1, 10);
        if(i == 1 || i%2==1) summ=summ + array[i];
        Console.Write($"{array[i]} ");
    }
    Console.Write($"сумма нечетных элементов в массиве => {summ}");
}

PrintArray(mass);
