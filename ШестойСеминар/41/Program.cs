/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

Console.WriteLine("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());

int count = 0;
Console.WriteLine("Введите числа:");
for (int i = 0; i < M; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество чисел больше 0 = " + count);