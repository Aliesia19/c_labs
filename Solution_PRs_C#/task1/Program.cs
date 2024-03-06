using System; //це простір імен, який містить основні класи та функції для взаємодії з системою

class Program
{
    static void Main(string[] args)
    {
        FindNumbersInInterval();
    }

    static void FindNumbersInInterval()
    {
        int n1, n2, n3;
        InputNumbers(out n1, out n2, out n3);

        int lastDigit = GetLastDigit(27);

        int lowerBound = 1;// Визначення інтервалу
        int upperBound = CalculateUpBound(lastDigit);

        Console.WriteLine($"numbers that belong to the interval [1, {upperBound}]:");
        CheckAndPrintNumbersInRange(n1, n2, n3, lowerBound, upperBound);
    }

    static void InputNumbers(out int n1, out int n2, out int n3)
    {
        Console.WriteLine("Enter three integers:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
    }

    static int GetLastDigit(int groupNumber)
    {
        return groupNumber % 10;
    }


    static int CalculateUpBound(int lastDigit)
    {
        return 10 + lastDigit;
    }


    static void CheckAndPrintNumbersInRange(int n1, int n2, int n3, int lowerBound, int upperBound)
    {
        if (IsInRange(n1, lowerBound, upperBound))
        {
            Console.WriteLine(n1);
        }
        if (IsInRange(n2, lowerBound, upperBound))
        {
            Console.WriteLine(n2);
        }
        if (IsInRange(n3, lowerBound, upperBound))
        {
            Console.WriteLine(n3);
        }
    }

    static bool IsInRange(int num, int lowerBound, int upperBound)
    {
        return num >= lowerBound && num <= upperBound;
    }
}