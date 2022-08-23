//  3. По заданному номеру дня недели вывести его название
Console.Clear();
Console.WriteLine("выбери цифру от 1 до 7");
int b = Convert.ToInt32(Console.ReadLine());

if(b==1)
{
    Console.WriteLine("сегодня пн");
}
if(b==2)
{
    Console.WriteLine("сегодня вт");
}
if(b==3)
{
    Console.WriteLine("сегодня ср");
}
if(b==4)
{
    Console.WriteLine("сегодня чт");
}
if(b==5)
{
    Console.WriteLine("сегодня птн");
}
if(b==6)
{
    Console.WriteLine("сегодня сбб");
}
if(b==7)
{
    Console.WriteLine("сегодня вскр");
}
else
{
    Console.WriteLine("неа, выбери цифру от 1 до 7");
}

