using System;

class Program
{
    static void Main(string[] args) // Метод ввода пользователем максимального и минималного числа
    {
        Console.WriteLine("Введите значение M:"); // Пользователь вводит переменную М(мин число)
        int M = Convert.ToInt32(Console.ReadLine()); // Конвертируется из стр в инт
        
        Console.WriteLine("Введите значение N:"); // Поьзователь вводит максималное число
        int N = Convert.ToInt32(Console.ReadLine()); // Конвертируется в инт
        
        Console.WriteLine("Чётные числа в промежутке от " + M + " до " + N + ":");
        PrintEvenNumbers(M, N); // Используем рекурсию с переменными М , Н
        
        
    }
    
    static void PrintEvenNumbers(int current, int max) // Метод нахождения четных натуральных чисел
    {
        if (current > max) // Проверка чисел до максимального числа который ввел пользователь
        {
            return; // Возвращает true or false
        }
        
        if (current % 2 == 0) // Проверка на четность числа
        {
            Console.Write($"{current} "); // Вывод числа если он прошел проверку
        }
        
        PrintEvenNumbers(current + 1, max); // Добавляем +1 чтобы перейти к след числу
    }
}


