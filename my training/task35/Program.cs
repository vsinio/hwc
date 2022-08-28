// 35. Определить, присутствует ли в заданном массиве, некоторое число 
Console.Clear();

Console.WriteLine("Hello, World!");

int[] mass = new int[8];

void PrintArray(int []array)
{
    int length = array.Length;

    for(int i=0; i < length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}


void FillArray(int []array)
{
    int length = array.Length;

    for(int i=0; i < length;i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void SearchInt(int[] array)
{
    int a = Convert.ToInt32(Console.ReadLine());
    int length = array.Length;
    int search = 0;

    for(int i = 0; i < length; i++)
    {
        if(array[i]==a)
            {
                search++;
            }
    }
    if(search > 0)
    {
        Console.WriteLine($"о да, в этом массиве есть искомое число и оно встречается {search} раз");
    }
    else
    {
        Console.WriteLine("нет, искомого числа нет :(");
    }
}   


PrintArray(mass);
FillArray(mass);
Console.WriteLine();
PrintArray(mass);
Console.WriteLine();
SearchInt(mass);