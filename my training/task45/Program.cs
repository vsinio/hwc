// 45. Показать числа Фибоначчи 1 1 2 3 5 8 13  ///1 + 1 =2 1 + 2 =3 2 + 3 =5
// костыль жесткий !!! 
Console.WriteLine("Введите число до которого отображать числа Фибоначчи:");

int a = Convert.ToInt32(Console.ReadLine());


void Fibonacci(int a)
{
    int num = 1;
    int num2 = 1;
    int summ = 0;
    Console.WriteLine(num);   
    Console.WriteLine(num);
    while(summ<a)
    {
        summ = num + num2; 
        Console.WriteLine(summ); 
        num = summ - num;
        num2 = summ;


    }
}

Fibonacci(a);