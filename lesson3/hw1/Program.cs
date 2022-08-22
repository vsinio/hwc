 int a = Convert.ToInt32(Console.ReadLine());


int palindr(int arg1)
{
    
    int a6 = arg1 % 10;
    int a5 = arg1 % 100 / 10;
    int a4 = arg1 / 100 % 10;
    int a3 = arg1 / 1000 % 10;
    int a2 = arg1 / 10000 % 10;
    int a1 = arg1 / 100000;
    int count=0;
    
    if (a6==a1 & a5==a2 & a4==a3)
    {
    count++;
    }
    
    return count;
}

if(palindr(a)==1)
Console.WriteLine("yes");
else
Console.WriteLine("no");
