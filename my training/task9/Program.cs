// 9. Показать последнюю цифру трёхзначного числа

Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if(a<=99 | a>=1000)
{
    Console.WriteLine("Нужно ввести трехзначное! Попробуй еще раз.");
}
else
{
    Console.WriteLine(a%10);
}
