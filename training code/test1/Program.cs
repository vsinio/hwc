//программа выводит случайное трехзначное и удаляет второе число
// string myString = myInt.ToString();

void Number1()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"трехзначное число: {num}");
    int a = num / 100;
    int b = num % 10;
    Console.Write(a);
    Console.Write(b);


}
Number1();