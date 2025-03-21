public class PalindromChecker
{
    public static bool IsPalindrome(string input)
    {
        string cleanedInput = input.Replace(" ","").ToLower();
        char[] charArray = cleanedInput.ToCharArray();
        Array.Reverse(charArray);
        string reversedInput = new string(charArray);

        return cleanedInput == reversedInput;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("А роза упала на лапу Азора"));
        Console.WriteLine(IsPalindrome("Роза"));

    }
}