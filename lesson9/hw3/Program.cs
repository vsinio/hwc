

Console.WriteLine("Введите числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Accerman (int m, int n)
{

    if( m == 0 ) 
    {
        return n + 1;
    }
    else if (m>0 && n==0)
    {
        return Accerman (m-1, 1);
    }
    else if (m>0 && n>0)
    {
        return Accerman (m-1, Accerman (m, n-1));
    }
    return Accerman(m,n);
}


Console.Write($"результат : {Accerman (a, b)}");