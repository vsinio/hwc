﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();

int[] mass = new int[4];

void PrintArray(int[] array)
{
    int length = array.Length;
    int pol = 0;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
            pol++;
        Console.Write($"{array[i]} ");
    }
    Console.Write($"количество четных чисел в массиве => {pol}");
}

PrintArray(mass);
