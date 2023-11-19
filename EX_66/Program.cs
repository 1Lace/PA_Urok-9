// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

using System;

class Program
{
    static int SumNaturalNumbers(int M, int N)
    {
        if (M == N)
        {
            return M;
        }
        else if (M < N)
        {
            return M + SumNaturalNumbers(M + 1, N);
        }
        else
        {
            return N + SumNaturalNumbers(N + 1, M);
        }
    }

    static void Main(string[] args)
    {
        // Ввод значений M и N
        Console.WriteLine("Введите значение M:");
        int M = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine());

        // Вычисление суммы и вывод результата
        int sum = SumNaturalNumbers(M, N);
        Console.WriteLine("Сумма натуральных элементов в промежутке от M до N: " + sum);
    }
}