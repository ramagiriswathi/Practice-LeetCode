<<<<<<< HEAD
﻿using System;

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
=======
﻿int[,] OriginalMatrix1 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

RotateMatrix.RotationalMatrixFinder(OriginalMatrix1);

for (int i = 0; i < OriginalMatrix1.GetLength(0); i++)
{
    for (int j = 0; j < OriginalMatrix1.GetLength(1); j++)
    {
        Console.Write(OriginalMatrix1[i, j] + " ");

    }
    Console.WriteLine();
}
//Adding to Github


public class RotateMatrix
{
    public static int[,] RotationalMatrixFinder(int[,] Matrix)
    {
        int rowlength = Matrix.GetLength(0);
        int collength = Matrix.GetLength(1);

        for (int i = 0; i < rowlength; i++)
        {
            for (int j = i; j < collength; j++)
            {
                int temp = Matrix[i, j];
                Matrix[i, j] = Matrix[j, i];
                Matrix[j, i] = temp;
            }
        }

        for (int i = 0; i < rowlength; i++)
        {
            for (int j = 0; j < collength / 2; j++)
            {
                int temp = Matrix[i, j];
                Matrix[i, j] = Matrix[i, collength - 1 - j];
                Matrix[i, collength - 1 - j] = temp;
            }
        }
        return Matrix;

>>>>>>> c75ea96575e50aecad045845f6805c6bd63ad3b3
    }
}
