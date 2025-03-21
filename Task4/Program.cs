public static class ArrayExtensions
{
    public static int Sum(this int[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Массив не должен быть пустым");
        }

        int sum = 0;
        foreach (var number in array)
        {
            sum += number;
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = numbers.Sum();
        Console.WriteLine($"Сумма элементов массива: {sum}");
    }
}