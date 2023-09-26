Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    double powI = Math.Pow(i, 3);
    Console.Write($"{powI}, ");
}
Console.Write("\b\b ");