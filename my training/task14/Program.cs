//Найти третью цифру числа или сообщить, что её нет
Console.Clear();
Console.WriteLine("Введите число для нахождения 3ей цифры");
int a = Convert.ToInt32(Console.ReadLine());

if(a<=99)
{
    Console.WriteLine("Третьей цифры нет :(");
}
else
{
    Console.WriteLine($"Третья цифра числа {a} = {a/10/10%10}");
}
