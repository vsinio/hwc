// 30. Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Кубы введенного числа:");
while(i<=a)  // цикл показать кубы от 1 до A
{
    int b = i*i*i;
    i++;
    if(b%2==0)
    {
        Console.WriteLine(b);
    }
    
    
}



