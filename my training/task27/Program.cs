// 27. Определить количество цифр в числе
//1 способ через строку
Console.Clear();
Console.WriteLine("Введите любое число или слово:");
string a = Console.ReadLine();
int i = 1;

while(i<a.Length)
{
    i++;
}

Console.WriteLine(i);

//2 способ через инт

Console.WriteLine("Введите любое число:");
int b = Convert.ToInt32(Console.ReadLine());
int index = 1;
while(b>=10)
{
    b=b/10;
    index++;
}


Console.Write(index);
