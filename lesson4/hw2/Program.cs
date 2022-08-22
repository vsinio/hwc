// Задача 27: Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.Clear();
Console.WriteLine("Введите число, чтобы получить сумму его цифр:");
int a = Convert.ToInt32(Console.ReadLine());


int summ1(int arg)

{

    int lastint = 0;
    int summa = 0;
    
    while(arg>=1)
    {
        lastint = arg % 10; 
        arg = arg / 10; 
        summa = summa + lastint;      
    }
    return summa;
}
int summfunc = summ1(a);
Console.WriteLine($"Сумма цифр числа {a} = {summfunc}");
