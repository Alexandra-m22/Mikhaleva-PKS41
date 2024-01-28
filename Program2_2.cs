using System;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = "apple", "banana", "orange", "pear";

        Console.WriteLine("Введите строку для поиска:");
        string search = Console.ReadLine();

        bool found = false;
        foreach (string str in strings)
        {
            if (str == search)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }