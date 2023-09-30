/*Задача 29.Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int Lenght = 8;
int[] array = new int [Lenght];
System.Console.WriteLine("Введите число min ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число max ");
int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
        System.Console.Write($"{array[i]}, ");   
    }
System.Console.WriteLine("\b\b ");

