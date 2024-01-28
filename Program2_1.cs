using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10;

        Console.WriteLine("Нечетные числа из массива:");
        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
    }