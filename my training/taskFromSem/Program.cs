﻿// метод перевода десятичного числа в двоичную СС
Console.Clear();
Console.WriteLine("Введите число в десятичной СС для перевода:");

int c = Convert.ToInt32(Console.ReadLine());

string translateNum(int b)
{   
    Console.WriteLine("Введите СС для перевода:");
    int CC = Convert.ToInt32(Console.ReadLine());
    string a = "";
    while (b != 0)
    {
        a = a + $"{b % CC}";
        b = b / CC;
    }
    char[] sReverse = a.ToCharArray();
    Array.Reverse(sReverse);
    a = new string(sReverse);
    return a;
}




Console.WriteLine(translateNum(c));
