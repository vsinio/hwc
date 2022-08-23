// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Clear();
Console.WriteLine("Введите два числа для проверки на кратность:");
int first = Convert.ToInt32(Console.ReadLine());
int sec = Convert.ToInt32(Console.ReadLine());

if(first%sec==0)
{
    Console.WriteLine($"Число {first} кратно {sec} и делится без остатка");
}
else
{
    Console.WriteLine($"Число {first} не кратно {sec}. Остаток = {first%sec}");    
}

