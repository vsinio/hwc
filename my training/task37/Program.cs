// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[] mass = new int[123];

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
        array[i] = i+1; // new Random().Next(1, 100); изначально array[i] = empty(пустой == 0)

    }
}
void search1099(int []array)
{
    int length = array.Length;
    int a = 0;
    

    for(int i=0; i < length;i++)
    {
        if(array[i]<100 & array[i]>10)
        {
            a++;
        }

    }
    Console.WriteLine($"Количество чисел находящихся в промежутке от 10 - 99= {a}");
}

FillArray(mass);
PrintArray(mass);
Console.WriteLine();
search1099(mass);
