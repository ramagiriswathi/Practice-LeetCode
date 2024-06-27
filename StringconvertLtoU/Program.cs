using System;

public class Conversion
{
    public static string StringConversion(string inputString)
    {
        char[] chars = inputString.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char ch = chars[i];

            if (ch >= 'a' && ch <= 'z')
            {
                chars[i] = (char)(ch - 32);
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                chars[i] = (char)(ch + 32);
            }
        }
        return new string(chars);
    }

    public static void Main(string[] args)
    {
        string myString = "Hello";
        string convertedString = StringConversion(myString);
        Console.WriteLine("Original string: " + myString);
        Console.WriteLine("Converted string: " + convertedString);
    }
}
