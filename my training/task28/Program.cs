// 28. Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите число для подсчета суммы цифр:");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int c = 0;
while(a>0)
{
    b=a%10;
    a=a/10;
    c=c+b;
}
Console.WriteLine(c);

