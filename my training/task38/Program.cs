// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] mass = new int[5];

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
        array[i] = new Random().Next(1,10); // new Random().Next(1, 100); изначально array[i] = empty(пустой == 0)

    }
}
void summa(int []array)
{
    int length = array.Length;
    int a = 0;
    

    for(int i=0; i < length;i++)
    {
        if(i % 2 != 1)
        {
            a=a+array[i];
        }

    }
    Console.WriteLine($"summa чисел находящихся в на нечет позиции = {a}");
}

FillArray(mass);
PrintArray(mass);
Console.WriteLine();
summa(mass);


