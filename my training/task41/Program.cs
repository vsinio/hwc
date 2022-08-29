// Выяснить являются ли три числа сторонами треугольника //решил сделать через массив
Console.Clear();

int[] mass = new int[3];


void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"|{i+1} сторонa = {array[i]} ");
    }
}

void FillArray(int[] array)
{
    int length = array.Length;
    Console.WriteLine("Введите 3 стороны треугольника для проверки:");
    for (int i = 0; i < length; i++)
    {
        int a = Convert.ToInt32(Console.ReadLine()); 
        array[i] = a;
    }
}

void checktriangle(int [] array)
{   int i = 0;
    if(array[i]<array[i+1]+array[i+2] & array[i+1]<array[i]+array[i+2] & array[i+2]<array[i]+array[i+1]) Console.WriteLine("YES");


    else
    {
        Console.WriteLine("No");
    }
}

FillArray(mass);
PrintArray(mass);
checktriangle(mass);