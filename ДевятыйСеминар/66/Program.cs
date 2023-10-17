/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


int SumNum(int M, int N)
{
    
     if (N < M)
        {
            return 0;
            
        }
        else if (N != M + 1)
        { 
            return N + SumNum(M, N - 1);
        }
        else
        {
            return M + N;
        }
}
System.Console.WriteLine(SumNum(M, N));
