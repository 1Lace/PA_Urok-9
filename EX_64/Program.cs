using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M:");
        int M = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите значение N:");
        int N = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Чётные числа в промежутке от " + M + " до " + N + ":");
        PrintEvenNumbers(M, N);
        
        
    }
    
    static void PrintEvenNumbers(int current, int max)
    {
        if (current > max)
        {
            return;
        }
        
        if (current % 2 == 0)
        {
            Console.Write($"{current} ");
        }
        
        PrintEvenNumbers(current + 1, max);
    }
}

