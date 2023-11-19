// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
    
    static void Main()
    {
        int m, n;
        Console.Write("Enter the value of m: ");
        m = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of n: ");
        n = int.Parse(Console.ReadLine());
        
        int result = Ackermann(m, n);
        Console.WriteLine("Ackermann({0}, {1}) = {2}", m, n, result);
    }
}