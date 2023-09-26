Console.WriteLine("Введите координату X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1:");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2:");
int Z2 = Convert.ToInt32(Console.ReadLine());




double arg1 = Math.Sqrt (Math.Pow((X1 - X2), 2) + Math.Pow((Y1 -Y2), 2) + Math.Pow((Z1 - Z2), 2));
double result = Math.Round(arg1, 2);
Console.WriteLine(result);