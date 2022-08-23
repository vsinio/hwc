// 25. Найти сумму чисел от 1 до А
Console.Clear();
Console.WriteLine("Введите число для отображения суммы:");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
int sum = 0;
while(i<=a)
{
    sum=sum+i;
    i++;
}
Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");