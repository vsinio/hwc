// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();
int[] mass = new int[8];

void PrintArray(int []array)
{
    int length = array.Length;

    for(int i=0; i < length;i++)
    {
        //array[i] = 0; // new Random().Next(1, 100); изначально array[i] = empty(пустой == 0)
        Console.Write($"{array[i]} ");
    }
}

void FillArray(int []array)
{
    int length = array.Length;

    for(int i=0; i < length;i++)
    {
        array[i] = new Random().Next(100, 1000); // изначально array[i] = empty(пустой == 0)
    }
}
void ChetNechet(int []array)
{
    int length = array.Length;
    int a = 0;
    int b = 0;

    for(int i=0; i < length;i++)
    {
        if(array[i]%2==0)
        {
            a++;
        }
        
        else
        {
            b++;
        }
    }
    Console.WriteLine($"Количество четных чисел = {a}, количество нечетных = {b}");
}


FillArray(mass);
Console.WriteLine();
PrintArray(mass);
Console.WriteLine();
ChetNechet(mass);