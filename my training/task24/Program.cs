// 24. Найти кубы чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число для отображения таблицы квадратов:");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i<=a)
{
    Console.WriteLine(i*i*i);
    i++;
}
