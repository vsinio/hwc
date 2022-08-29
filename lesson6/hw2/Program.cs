// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//y = k1 * x + b1, y = k2 * x + b2  

//k1 * x + b1 = k2 * x + b2
//(k1  - k2) * x = b2-b1
//x = (k1 - k2) / (b1-b2)
//y = k1*x +b1 k2 b2


Console.Clear();
Console.WriteLine("Введите по очереди значения b1,k1,b2,k2:");
int b1 = Convert.ToInt32(Console.ReadLine()); //2
int k1 = Convert.ToInt32(Console.ReadLine()); //5
int b2 = Convert.ToInt32(Console.ReadLine()); //4
int k2 = Convert.ToInt32(Console.ReadLine()); //9

void dotperes(double b1,double k1,double b2,double k2)
{
    if(k1!=k2)
    {
        double x = (b1 - b2) / (k2 - k1);  // 
        double y = (k2*b1-k1*b2)/(k2-k1);//        

        Console.WriteLine($"точка пересечения = > {x} , {y}");
    }
    else 
    Console.WriteLine("Точки нет");

}
dotperes(b1,k1,b2,k2);
