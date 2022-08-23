//12. Удалить вторую цифру трёхзначного числа
Console.Clear();
Console.WriteLine("Введи 3х значное число");
int a = Convert.ToInt32(Console.ReadLine());
int first = a/100;
int last = a%10;

if(a<=99 | a>=1000)
{
Console.WriteLine("Число не трехзначное");
}
else
{
    Console.Write(first);
    Console.Write(last);
}