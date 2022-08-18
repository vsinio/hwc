int a = Convert.ToInt32(Console.ReadLine());

string cube(int arg1)
{
    int count=1;
    string ab = " ";
    
    while (count < arg1+1)
        {
        int cube1 = count * count * count;
        Console.WriteLine(cube1);
        count++;
        
        }
    return ab;
}


Console.WriteLine(cube(a));