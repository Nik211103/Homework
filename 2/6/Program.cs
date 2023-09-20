/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0) {
            Console.WriteLine("Число является четным.");
        } else {
            Console.WriteLine("Число не является четным.");
        }