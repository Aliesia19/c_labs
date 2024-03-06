using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Enter the lengths of the sides of the triangle:");
        Console.Write("Side a: ");
        a = ReadPositiveDouble();

        Console.Write("Side b: ");
        b = ReadPositiveDouble();

        Console.Write("Side c: ");
        c = ReadPositiveDouble();

        if (IsTriangleValid(a, b, c))
        {
            double perimeter = CalculatePerimeter(a, b, c);
            double square = CalculateSquare(a, b, c);

            Console.WriteLine($"Perimeter of triangle: {perimeter}");
            Console.WriteLine($"Square of triangle: {square}");

            string triangleType = DetermineTriangleType(a, b, c);
            Console.WriteLine($"Type of triangle: {triangleType}");
        }
        else
        {
            Console.WriteLine("A triangle with such sides does not exist.");
        }
    }

    static double ReadPositiveDouble()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Please, enter thepositive value.");
        }
        return number;
    }

    static bool IsTriangleValid(double a, double b, double c) // дійсність трикутника
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static double CalculatePerimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    static double CalculateSquare(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static string DetermineTriangleType(double a, double b, double c) // визначення типу трикутника
    {
        if (a == b && b == c)
            return "equilateral";
        else if (a == b || a == c || b == c)
            return "isosceles";
        else
            return "versatile";
    }
}