public class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        input = input.Replace(" ", "").ToLower();
        return IsPalindromeRecursive(input, 0, input.Length - 1);
    }

    private static bool IsPalindromeRecursive(string input, int left, int right)
    {
        if (left >= right)
        {
            return true;
        }

        if (input[left] != input[right])
        {
            return false;
        }
        return IsPalindromeRecursive(input, left + 1, right - 1);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("racecar"));
        Console.WriteLine(IsPalindrome("А роза упала на лапу Азора"));
        Console.WriteLine(IsPalindrome("Роза"));
    }
}