using System;
using System.Linq;

public class Functions
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public int StringLength(string str)
    {
        return str.Length;
    }

    public int MaxValue(int[] numbers)
    {
        return numbers.Max();
    }

    public int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    public bool IsPalindrome(string str)
    {
        string reversed = new string(str.Reverse().ToArray());
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    public int[] MergeArrays(int[] arr1, int[] arr2)
    {
        return arr1.Concat(arr2).ToArray();
    }

    public bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public int SumOfMatrix(int[,] matrix)
    {
        int sum = 0;
        foreach (int num in matrix)
        {
            sum += num;
        }
        return sum;
    }
}