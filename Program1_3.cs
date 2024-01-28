using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите первое число от 0 до 10: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число от 0 до 10: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
            {
                Console.WriteLine("Ошибка! Введены недопустимые числа. Попробуйте еще раз.");
            }
            else
            {
                int result = num1 * num2;
                Console.WriteLine("Результат умножения: result");
                break;
            }
        }
    }