
using System;

class Program
{
    static void Main(string[] args)
    {
        int lastDigit = 27;
        int[] X = GenerateArray(lastDigit);

        FindMinMax(X, out int min, out int max);

        Console.WriteLine($"Min value: {min}");
        Console.WriteLine($"Max value: {max}");
    }

    static int[] GenerateArray(int lastDigit)
    {
        int[] array = new int[10 + lastDigit];
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)// від 0 до 99
        {
            array[i] = rand.Next(100);
        }

        return array;
    }
    static void FindMinMax(int[] array, out int min, out int max)// 
    {
        min = array[0]; // Початкове значення мінімуму - перший елемент масиву
        max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            else if (array[i] > max)
            {
                max = array[i];
            }
        }
    }
}