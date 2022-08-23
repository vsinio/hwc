// 15. Дано число. Проверить кратно ли оно 7 и 23
Console.Clear();
Console.WriteLine("Введите число для проверки кратности на 7 и 23");
int a = Convert.ToInt32(Console.ReadLine());
if(a%7==0 & a%23==0)
{
    Console.WriteLine($"Да, число {a} кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Нет, число {a} не кратно 7 и 23");
}