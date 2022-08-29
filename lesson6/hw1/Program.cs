//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Введите размер массива:");
int m = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[m];

void PrintArray(int[] array)
{
    int length = array.Length;

    for(int i=0; i < length;i++)
    {
        //array[i] = 0; // new Random().Next(1, 100); изначально array[i] = empty(пустой == 0)
        Console.Write($"{array[i]} ");
    }
}

void FillArrayByUser(int[] array)
{
    int length = array.Length;
    {
        Console.WriteLine($"Введите {m} чисел, для заполнения массива");
        for(int i=0;i<length; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            array[i] = a;
        }
    }
    
}

int HowManyBigger(int[] array)
{
    int length = array.Length;
    int integerbiggerzero = 0;
    {
        for(int i = 0; i<length; i++)
        {
            if(array[i]>0) integerbiggerzero++;
        }
    }
    return integerbiggerzero;
}



FillArrayByUser(mass);
PrintArray(mass);
Console.WriteLine($" => {HowManyBigger(mass)}");
