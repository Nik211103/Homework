/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Введите число N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Четные числа от 1 до {0} ");
        
        for (int i = 2; i <= n; i += 2) {
            Console.WriteLine(i);
        }
