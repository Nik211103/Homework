/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
System.Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите числе B: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = 1;
if (B > 0)
{
    while (count <= B )
    {
        result *= A;
        count++;   
    }
System.Console.WriteLine($"Число {A} в степени {B} = {result}.");
}
else
{
    System.Console.WriteLine($"Число B должно быть больше нуля. Число которое вы ввели {B}");
}