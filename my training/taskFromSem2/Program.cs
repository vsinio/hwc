

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


Console.WriteLine("Введите целое значение — размер массива");
int size = int.Parse(Console.ReadLine());               // спрашиваем длину массива у пользователя
int[] array = new int[size];                            // объявляем массив на size элементов
for (int i=0; i < array.Length; i++)                   // проходим весь массив от 0 до size - 1
    {
    Console.WriteLine("Введите число — элемент массива");
    array[i] = int.Parse(Console.ReadLine()); 
    }

PrintArray(array);