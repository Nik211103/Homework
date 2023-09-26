System.Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
 
    if (9999 < number && number < 99999)
    {
    int first = number / 10000; //5 000
    int second = number / 1000%10;// 5 0 00
    int third = number / 100%10;
    int fourth = number /10%10;//500 0
    int fifth = number%10;

        if (first == fifth && second == fourth)
        {
        System.Console.WriteLine($"Число {number} палиндром");
        }
        else
        {
        System.Console.WriteLine($"Число {number} не палиндром");
        }
    }
    else
    {
    System.Console.WriteLine("Введенно не пятизначное число.");
    }