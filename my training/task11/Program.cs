// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Clear();

Console.WriteLine("Введите число от 10 до 99 для выяснения бОльшей цифры:");
int a = Convert.ToInt32(Console.ReadLine());
int b = a%10;
int c = a/10;
if(a<=9 | a>=100)
{
    Console.WriteLine("Число не в указанном диапазоне.");
}
else
{
    if(b>c)
    {
        Console.WriteLine($"Наибольшая цифра числа {a} = {b}!");
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра числа {a} = {c}!");
    }
}
