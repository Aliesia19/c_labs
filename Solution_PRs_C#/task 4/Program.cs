using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the last digit of your number in the group list: ");
        int lastDigit = ReadLastDigit();

        int[] X = GenerateArray(lastDigit);

        Console.WriteLine("Array X:");
        PrintArray(X);

        Console.Write("Enter a number M: ");
        int M = ReadPositiveInt();

        int[] Y = FilterArrayByAbsoluteValue(X, M);
        Console.WriteLine($"number М: {M}");

        Console.WriteLine("Array Y:");
        PrintArray(Y);
    }

    static int ReadLastDigit() //введення останньої цифри номеру у списку групи
    {
        int lastDigit;
        while (!int.TryParse(Console.ReadLine(), out lastDigit) || lastDigit < 0 || lastDigit > 9)
        {
            Console.WriteLine("Please enter a number from 0 to 9.");
        }
        return lastDigit;
    }

    static int[] GenerateArray(int lastDigit)
    {
        int[] array = new int[10 + lastDigit];
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 101); //випадкові числа від -100 до 100
        }

        return array;
    }

    static int ReadPositiveInt() // введення додатного цілого числа
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
        }
        return number;
    }

    static int[] FilterArrayByAbsoluteValue(int[] array, int M)    //фільтрація масиву X за модулем числа М
    {
        int count = 0;
        foreach (int num in array)
        {
            if (Math.Abs(num) > M)// чи поточний елемент масиву num більший за модулем від числа M.
            {
                count++;
            }
        }

        int[] filteredArray = new int[count];//масив міститиме відфільтровані елементи масиву array.
        int index = 0;
        foreach (int num in array)
        {
            if (Math.Abs(num) > M)
            {
                filteredArray[index++] = num;
            }
        }

        return filteredArray;
    }
    static void PrintArray(int[] array)// виведення на екран 
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
