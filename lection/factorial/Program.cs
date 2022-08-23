// рекурсия факториал пример

double Factorial(int n)
{
    //1!=1
    if (n == 1)
        return 1;
    else
        return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(3));

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {(Factorial(i))}");
}

//функция фибоначчи

//f(1)=1
//f(2)=1
//f(n)=f(n-1)+f(n-2)

int Fibonacci(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i=1; i<50;i++)
{
    Console.WriteLine($"f{i} = {Fibonacci(i)}");
}