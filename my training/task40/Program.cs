//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] mass = new double[8];

void PrintArray(double []array)
{
    double length = array.Length;

    for(int i=0; i < length;i++)
    {
        //array[i] = 0; // new Random().Next(1, 100); изначально array[i] = empty(пустой == 0)
        Console.Write($"|{array[i]}| ");
    }
}
void FillArray(double []array)
{
    int length = array.Length;

    for(int i=0; i < length;i++)
    {
        array[i] = new Random().Next(10, 100);
        array[i] = array[i] / 10;
    }
}

void difference (double []array)
{
    int length = array.Length;
    double min = array[0];
    double max = array[0];
    for(int i = 0; i<length; i++)
    {
        if(array[i]<min) 
        {
            min=array[i];
        }
        if(array[i]>max) 
        {
            max=array[i];
        }
    }
    Console.WriteLine($"разница между наибольшим и наименьшим элементом = {max - min}");
}

FillArray(mass);
Console.WriteLine();
PrintArray(mass);
difference(mass);