///Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
///нельзя использовать pow
///3, 5 -> 243 (3⁵)

Console.Write("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());



int stepen(int a, int b)
{   

    int c = a ;

    for(int count = 1; count < b; count++)
    {
        c = c * a;;
    } 
    return c;
}
Console.WriteLine(stepen(a,b));
