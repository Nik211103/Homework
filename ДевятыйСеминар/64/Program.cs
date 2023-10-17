﻿
/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Print(int N)
{
    if(N != 0)
    {
    System.Console.Write($"{N} ");
    Print(N - 1);
    }
}
Print(N);


