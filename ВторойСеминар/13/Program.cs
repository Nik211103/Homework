/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

System.Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int arg1 = num / 100;
    if (arg1 == 0){
    System.Console.WriteLine($"У числа {num} нет третьей цифры.");
    }

    else{
    int a = num% 10;
    System.Console.WriteLine($"Третьея цифра числа {num} -> {a}");
    }
