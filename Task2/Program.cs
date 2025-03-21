public class Triangle
{
    public static void TrianglePS(double a, out double P, out double S)
    {
        P = 3 * a;
        S = (Math.Sqrt(3) / 4) * a * a;
    }

    static void Main(string[] args)
    {
        double[] sides = { 3.0, 4.5, 6.0 };

        foreach (var a in sides)
        {
            TrianglePS(a, out double P, out double S);
            Console.WriteLine($"Для стороны a = {a}: Периметр P = {P}, Площадь S = {S}");
        }
    }
}