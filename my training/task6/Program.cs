//  6. Выяснить является ли число чётным
Console.Clear();
Console.WriteLine("Введите число для проверки на четность:");
int a = Convert.ToInt32(Console.ReadLine());
if(a%2==1)
{
    Console.WriteLine($"Число {a} = нечет");
}
if(a%2==0)
{
    Console.WriteLine($"Число {a} = чет");
}


