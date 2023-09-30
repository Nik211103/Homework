/*Задача 27.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int NumCount(int a)
{
    if (a > 0)
    {
        int sum = 0;
        int b;
        while (a > 0)
        {
            b = a % 10;
            sum += b;
            a /= 10;
        }
        return sum;
    }
    else
    {
        System.Console.WriteLine("Число должно быть положительным.");    
    } 
    return 0;
    
}
System.Console.WriteLine($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе = {NumCount(a)}");

