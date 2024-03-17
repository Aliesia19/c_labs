using C__LR_3_t2;

class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(0, 4, "B");
        Point C = new Point(3, 0, "C");

        Figure figure = new Figure(A, B, C);
        figure.PerimeterCalculator();
    }
}