//метод заполнения массива нулями и вывод его на экран

int[] mass = new int[8];

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        //array[i] = 0; // new Random().Next(1, 100); изначально array[i] = empty(пустой == 0)
        Console.Write($"{array[i]} ");
    }
}

PrintArray(mass);

//заполнение массива рандомными от 10 до 10

void FillArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

//метод поиска числа в одномерном массиве
void SearchInt(int[] array)
{
    int a = Convert.ToInt32(Console.ReadLine());
    int length = array.Length;
    int search = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] == a)
        {
            search++;
        }
    }
    if (search > 0)
    {
        Console.WriteLine($"в этом массиве есть искомое число и оно встречается {search} раз");
    }
    else
    {
        Console.WriteLine("нет, искомого числа нет :(");
    }
}

// метод создания и вывода нового двум массива

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//метод генерации чисел в заданном масиве
void FillArray(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 5];

//создание массива + вывод =>заполнение => вывод результата

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
