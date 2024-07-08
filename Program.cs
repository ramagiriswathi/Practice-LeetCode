using System;

public class VowelReversal
{
    public static string VowelReversalFunction(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] chars = input.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;

        while (left < right)
        {
            while (left < right && !IsVowel(chars[left], vowels))
            {
                left++;
            }
            while (left < right && !IsVowel(chars[right], vowels))
            {
                right--;
            }
            if (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }
        }

        return new string(chars);
    }

    private static bool IsVowel(char c, char[] vowels)
    {
        foreach (char vowel in vowels)
        {
            if (c == vowel)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main()
    {
        string input = "casio";
        string result = VowelReversalFunction(input);
        Console.WriteLine(result);
    }
}
